using System;
using System.Runtime.InteropServices;

namespace DllSBPL_C
{
    public class Print
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public class typDocInfo
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public string strDocName;
            [MarshalAs(UnmanagedType.LPStr)]
            public string strOutputFile;
            [MarshalAs(UnmanagedType.LPStr)]
            public string strDatatype;
        }

        // ====================================================================================================
        // 指定されたプリンタまたはプリントサーバーを識別するハンドルを取得します
        // ====================================================================================================
        [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi,
            ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        private static extern bool OpenPrinter(string szPrinter, ref IntPtr hPrinter, IntPtr pd);

        // ====================================================================================================
        // プリンタオブジェクトをクローズします
        // ====================================================================================================
        [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true,
            CallingConvention = CallingConvention.StdCall)]
        private static extern bool ClosePrinter(IntPtr hPrinter);

        // ====================================================================================================
        // 印刷のために文書がスプールされたことを印刷スプーラに通知します
        // ====================================================================================================
        [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi,
            ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        private static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] typDocInfo di);

        // ====================================================================================================
        // 指定されたプリンタの印刷ジョブを終了します
        // ====================================================================================================
        [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true,
            CallingConvention = CallingConvention.StdCall)]
        private static extern bool EndDocPrinter(IntPtr hPrinter);

        // ====================================================================================================
        // 指定されたプリンタにデータを書き込むよう印刷スプーラに通知します
        // ====================================================================================================
        [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true,
            CallingConvention = CallingConvention.StdCall)]
        public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, ref Int32 dwWritten);

        // ====================================================================================================
        // 
        // ====================================================================================================
        public static bool SatoOpen(ref IntPtr Handle, string PrintName, string DocumentName, ref string ErrMsg)
        {
            bool SatoOpenFLG = false;

            try
            {
                typDocInfo sDocInfo = new typDocInfo();
                Int32 Level = 1;

                // プリンタハンドルを取得します
                if (!OpenPrinter(PrintName, ref Handle, IntPtr.Zero))
                {
                    ErrMsg = "プリンタハンドルの取得に失敗しました。";
                    return SatoOpenFLG;
                }

                // 印刷ジョブの設定
                sDocInfo.strDocName = DocumentName;
                sDocInfo.strOutputFile = null;
                sDocInfo.strDatatype = null;

                // 印刷のために文書がスプールされたことを印刷スプーラに通知します
                if (!StartDocPrinter(Handle, Level, sDocInfo))
                {
                    ErrMsg = "スプーラの通知に失敗しました。";
                    return SatoOpenFLG;
                }

                SatoOpenFLG = true;
            }
            catch (Exception e)
            {
                // ====================================================================================================
                // エラーが発生した場合にエラー時の処理を記述します
                // ====================================================================================================
                ErrMsg = e.Message;

            }

            // 戻り値の設定
            return SatoOpenFLG;
        }

        // ====================================================================================================
        // 出力処理
        // ====================================================================================================
        public static bool SatoSend(IntPtr Handle,byte[] bs,ref string ErrMsg)
        {

            bool SatoSendFLG = false;

            try
            {
                IntPtr UnmanagedBytes;
                Int32 Written = 0;

                // 指定したサイズのメモリ ブロックを割り当てます
                UnmanagedBytes = Marshal.AllocCoTaskMem(bs.Length);
                // 配列にデータをコピーします
                Marshal.Copy(bs, 0, UnmanagedBytes, bs.Length);
                // データを送信します
                WritePrinter(Handle, UnmanagedBytes, bs.Length, ref Written);
                // 割り当てたメモリ ブロックを解放します
                Marshal.FreeCoTaskMem(UnmanagedBytes);

                SatoSendFLG = true;
            }
            catch (Exception e)
            {
                // ====================================================================================================
                // エラーが発生した場合にエラー時の処理を記述します
                // ====================================================================================================
                ErrMsg = e.Message;

            }

            // 戻り値の設定
            return SatoSendFLG;
        }

        // ====================================================================================================
        // クローズ処理
        // ====================================================================================================
        public static bool SatoClose(IntPtr Handle, ref String ErrMsg)
        {
            bool SatoCloseFLG = true;

            try
            {
                if (!EndDocPrinter(Handle))
                {
                    ErrMsg = "印刷ジョブの終了に失敗しました。";
                    SatoCloseFLG = false;
                }

                if (!ClosePrinter(Handle))
                {
                    ErrMsg = "プリンタクローズに失敗しました。";
                    SatoCloseFLG = false;
                }

            }
            catch (Exception e)
            {
                // ====================================================================================================
                // エラーが発生した場合にエラー時の処理を記述します
                // ====================================================================================================
                ErrMsg = e.Message;
                SatoCloseFLG = false;

            }

            // 戻り値の設定
            return SatoCloseFLG;

        }
    }
}
