public void MaximizeButton(int code, Rect rect) 
{
    if(code == Winuser.WM.NCHITTEST)
    {
        if (Environment.OSVersion.Version.Build >= 20000)
        {
            try
            {
                int x = lparam.ToInt32() & 0xffff;
                int y = lparam.ToInt32() >> 16;

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

    if(code == Winuser.WM.NCLBUTTONDOWN)
    {
        try
        {
            int x = lparam.ToInt32() & 0xffff;
            int y = lparam.ToInt32() >> 16;

            if (rect.Contains(new Point(x, y)))
            {
                handled = true;
            }
        }
        catch (OverflowException)
        {
            handled = true;
        }
        break;
    }
}
