public IntPtr MaximizeButton(int code, Rect target, IntPtr mousePos, out bool handled)
{
    handled = false;

    if (code == Winuser.WM.NCHITTEST)
    {
        if (Environment.OSVersion.Version.Build >= 20000)
        {
            try
            {
                int x = mousePos.ToInt32() & 0xffff;
                int y = mousePos.ToInt32() >> 16;

                if (target.Contains(new Point(x, y)))
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
    }

    if (code == Winuser.WM.NCLBUTTONDOWN)
    {
        try
        {
            int x = mousePos.ToInt32() & 0xffff;
            int y = mousePos.ToInt32() >> 16;

            if (target.Contains(new Point(x, y)))
            {
                handled = true;
                this.WindowState = WindowState.Maximized;
                return new IntPtr(Winuser.HT.MAXBUTTON);
            }
        }
        catch (OverflowException)
        {
            handled = true;
        }
    }

    return IntPtr.Zero;
}
