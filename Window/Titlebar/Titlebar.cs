public IntPtr TitleBar(int code, Rect target, IntPtr mousePos, out bool handled)
{
    handled = false;

    if (code == Winuser.WM.NCHITTEST)
    {
        try
        {
            int x = mousePos.ToInt32() & 0xffff;
            int y = mousePos.ToInt32() >> 16;

            if (target.Contains(new Point(x, y)))
            {
                handled = true;
                return new IntPtr(Winuser.HT.CAPTION);
            }
        }
        catch (OverflowException)
        {
            handled = true;
        }
    }

    return IntPtr.Zero;
}
