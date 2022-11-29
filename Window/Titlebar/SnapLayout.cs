private IntPtr HwndSourceHook(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam, ref bool handled)
{
    switch (msg)
    {
        case Winuser.WM.NCHITTEST:
        {
            if (Environment.OSVersion.Version.Build >= 20000)
            {
                try
                {
                    int x = lparam.ToInt32() & 0xffff;
                    int y = lparam.ToInt32() >> 16;

                    var rect = ; // Relative to screen coordinates

                    if (rect.Contains(new Point(x, y)))
                    {
                        handled = true;
                        return new IntPtr(Winuser.HT.MAXBUTTON);
                    }
                }
                catch (OverflowException)
                {
                    handled = true;
                }
            }
            break;
        }
    }
}
