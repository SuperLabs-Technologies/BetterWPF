// Use MaximizeButton.cs to remove the windows styled maximize button when clicking
public void SnapLayout(int code, Rect rect) 
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
}
