void HookSource() =>
    HwndSource.FromHwnd(new WindowInteropHelper(this).Handle).AddHook(HwndSourceHook);

private IntPtr HwndSourceHook(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam, ref bool handled)
{
    return IntPtr.Zero;
}
