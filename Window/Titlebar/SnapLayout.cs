public IntPtr SnapLayout(int code, Rect target, IntPtr mousePos, out bool handled)
{
    handled = false;

    if (code == Winuser.WM.NCHITTEST)
    {
        int x = mousePos.ToInt32() & 0xffff;
        int y = mousePos.ToInt32() >> 16;

        if (Environment.OSVersion.Version.Build >= 20000)
        {
            try
            {
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

    // Hook the button down event to prevent the old windows button from showing
    if (code == Winuser.WM.NCLBUTTONDOWN)
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

    return IntPtr.Zero;
}
