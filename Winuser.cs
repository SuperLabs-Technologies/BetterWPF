using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Winuser
{
    /// <summary>
    /// Window Message Notification codes
    /// </summary>
    public class WM
    {
        /// <summary>
        /// Notifies a window that the user generated an application command event, for example, by clicking an application command button using the mouse or typing an application command key on the keyboard.
        /// </summary>
        public const int APPCOMMAND = 0x0319;

        /// <summary>
        /// Sent to the window that is losing the mouse capture.
        /// </summary>
        public const int CAPTURECHANGED = 0x0215;

        /// <summary>
        /// Posted when the user double-clicks the left mouse button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.
        /// </summary>
        public const int LBUTTONDBLCLK = 0x0203;

        /// <summary>
        /// Posted when the user presses the left mouse button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.
        /// </summary>
        public const int LBUTTONDOWN = 0x0201;

        /// <summary>
        /// Posted when the user releases the left mouse button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.
        /// </summary>
        public const int LBUTTONUP = 0x0202;

        /// <summary>
        /// Posted when the user double-clicks the middle mouse button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.
        /// </summary>
        public const int MBUTTONDBLCLK = 0x0209;

        /// <summary>
        /// Posted when the user presses the middle mouse button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.
        /// </summary>
        public const int MBUTTONDOWN = 0x0207;

        /// <summary>
        /// Posted when the user releases the middle mouse button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.
        /// </summary>
        public const int MBUTTONUP = 0x0208;

        /// <summary>
        /// Sent when the cursor is in an inactive window and the user presses a mouse button. The parent window receives this message only if the child window passes it to the DefWindowProc function.
        /// </summary>
        public const int MOUSEACTIVATE = 0x0021;

        /// <summary>
        /// Posted to a window when the cursor hovers over the client area of the window for the period of time specified in a prior call to TrackMouseEvent.
        /// </summary>
        public const int MOUSEHOVER = 0x02A1;

        /// <summary>
        /// Sent to the focus window when the mouse's horizontal scroll wheel is tilted or rotated. TheDefWindowProcfunction propagates the message to the window's parent. There should be no internal forwarding of the message, because DefWindowProc propagates it up the parent chain until it finds a window that processes it.
        /// </summary>
        public const int MOUSEHWHEEL = 0x020E;

        /// <summary>
        /// Posted to a window when the cursor leaves the client area of the window specified in a prior call to TrackMouseEvent.
        /// </summary>
        public const int MOUSELEAVE = 0x02A3;

        /// <summary>
        /// Posted to a window when the cursor moves. If the mouse is not captured, the message is posted to the window that contains the cursor. Otherwise, the message is posted to the window that has captured the mouse.
        /// </summary>
        public const int MOUSEMOVE = 0x0200;

        /// <summary>
        /// Sent to the focus window when the mouse wheel is rotated. The DefWindowProc function propagates the message to the window's parent. There should be no internal forwarding of the message, because DefWindowProc propagates it up the parent chain until it finds a window that processes it.
        /// </summary>
        public const int MOUSEWHEEL = 0x020A;

        /// <summary>
        /// Sent to a window in order to determine what part of the window corresponds to a particular screen coordinate. This can happen, for example, when the cursor moves, when a mouse button is pressed or released, or in response to a call to a function such as WindowFromPoint. If the mouse is not captured, the message is sent to the window beneath the cursor. Otherwise, the message is sent to the window that has captured the mouse.
        /// </summary>
        public const int NCHITTEST = 0x0084;

        /// <summary>
        /// Posted when the user double-clicks the left mouse button while the cursor is within the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
        /// </summary>
        public const int NCLBUTTONDBLCLK = 0x00A3;

        /// <summary>
        /// Posted when the user presses the left mouse button while the cursor is within the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
        /// </summary>
        public const int NCLBUTTONDOWN = 0x00A1;

        /// <summary>
        /// Posted when the user releases the left mouse button while the cursor is within the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
        /// </summary>
        public const int NCLBUTTONUP = 0x00A2;

        /// <summary>
        /// Posted when the user double-clicks the middle mouse button while the cursor is within the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
        /// </summary>
        public const int NCMBUTTONDBLCLK = 0x00A9;

        /// <summary>
        /// Posted when the user presses the middle mouse button while the cursor is within the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
        /// </summary>
        public const int NCMBUTTONDOWN = 0x00A7;

        /// <summary>
        /// Posted when the user releases the middle mouse button while the cursor is within the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
        /// </summary>
        public const int NCMBUTTONUP = 0x00A8;

        /// <summary>
        /// 	Posted to a window when the cursor hovers over the nonclient area of the window for the period of time specified in a prior call toTrackMouseEvent.
        /// </summary>
        public const int NCMOUSEHOVER = 0x02A0;

        /// <summary>
        /// Posted to a window when the cursor leaves the nonclient area of the window specified in a prior call toTrackMouseEvent.
        /// </summary>
        public const int NCMMOUSELEAVE = 0x02A2;

        /// <summary>
        /// Posted to a window when the cursor is moved within the nonclient area of the window. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
        /// </summary>
        public const int NCMOUSEMOVE = 0x00A0;

        /// <summary>
        /// Posted when the user double-clicks the right mouse button while the cursor is within the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
        /// </summary>
        public const int NCRBUTTONDBLCLK = 0x00A6;

        /// <summary>
        /// Posted when the user presses the right mouse button while the cursor is within the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
        /// </summary>
        public const int NCRBUTTONDOWN = 0x00A4;

        /// <summary>
        /// Posted when the user releases the right mouse button while the cursor is within the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
        /// </summary>
        public const int NCRBUTTONUP = 0x00A5;

        /// <summary>
        /// Posted when the user double-clicks the first or second X button while the cursor is in the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
        /// </summary>
        public const int NCXBUTTONDBLCLK = 0x00AD;

        /// <summary>
        /// Posted when the user presses the first or second X button while the cursor is in the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
        /// </summary>
        public const int NCXBUTTONDOWN = 0x00AB;

        /// <summary>
        /// Posted when the user releases the first or second X button while the cursor is in the nonclient area of a window. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.
        /// </summary>
        public const int NCXBUTTONUP = 0x00AC;

        /// <summary>
        /// Posted when the user double-clicks the right mouse button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.
        /// </summary>
        public const int RBUTTONDBLCLK = 0x0206;

        /// <summary>
        /// Posted when the user presses the right mouse button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.
        /// </summary>
        public const int RBUTTONDOWN = 0x0204;

        /// <summary>
        /// Posted when the user releases the right mouse button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.
        /// </summary>
        public const int RBUTTONUP = 0x0205;

        /// <summary>
        /// Posted when the user double-clicks the first or second X button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.
        /// </summary>
        public const int XBUTTONDBLCLK = 0x020D;

        /// <summary>
        /// Posted when the user presses the first or second X button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.
        /// </summary>
        public const int XBUTTONDOWN = 0x020B;

        /// <summary>
        /// Posted when the user releases the first or second X button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.
        /// </summary>
        public const int XBUTTONUP = 0x020C;
    }

    /// <summary>
    /// Hit Test codes
    /// </summary>
    public class HT
    {
        /// <summary>
        ///  In a client area
        /// </summary>
        public const int CLIENT = 1;

        /// <summary>
        /// In a title bar
        /// </summary>
        public const int CAPTION = 2;

        /// <summary>
        /// In a window menu or in a Close button in a child window
        /// </summary>
        public const int SYSMENU = 3;

        /// <summary>
        /// In a size box (same as HTGROWBOX)
        /// </summary>
        public const int SIZE = 4;

        /// <summary>
        /// In a menu
        /// </summary>
        public const int MENU = 5;

        /// <summary>
        /// In a horizontal scrollbar
        /// </summary>
        public const int HSCROLL = 6;

        /// <summary>
        /// In a vertical scroll bar
        /// </summary>
        public const int VSCROLL = 7;

        /// <summary>
        /// In a Minimize button
        /// </summary>
        public const int MINBUTTON = 8;

        /// <summary>
        /// In a Maximize button
        /// </summary>
        public const int MAXBUTTON = 9;

        /// <summary>
        /// In the left border of a resizeable window (the user can click the mouse to resize the window horizontally)
        /// </summary>
        public const int LEFT = 10;

        /// <summary>
        /// In the right border of a resizeable window (the user can click the mouse to resize the window horizontally)
        /// </summary>
        public const int RIGHT = 11;

        /// <summary>
        /// In the upper-horizontal border of a window
        /// </summary>
        public const int TOP = 12;

        /// <summary>
        /// In the upper-left corner of a window border
        /// </summary>
        public const int TOPLEFT = 13;

        /// <summary>
        /// In the upper-right corner of a window border
        /// </summary>
        public const int TOPRIGHT = 14;

        /// <summary>
        /// In the lower-horizontal border of a resizeable window (the user can click the mouse to resize the window vertically)
        /// </summary>
        public const int BOTTOM = 15;

        /// <summary>
        /// In the lower-left corner of a border of a resizeable window (the user can click the mouse to resize the window diagonally)
        /// </summary>
        public const int BOTTOMLEFT = 16;

        /// <summary>
        /// In the lower-right corner of a border of a resizeable window (the user can click the mouse to resize the window diagonally)
        /// </summary>
        public const int BOTTOMRIGHT = 17;

        /// <summary>
        /// In the border of a window that does not have a sizing border
        /// </summary>
        public const int BORDER = 18;

        /// <summary>
        /// Deprecated code; not in use any more -- It was added back in Windows 95 for reasons lost to the mists of time, but when the reason for adding it vanished (maybe a feature got cut), it was too late to remove it from the header file because that would require renumbering HTCLOSE and HTHELP, two values which were in widespread use already. So the value just stayed in the header file, taking up space but accomplishing nothing.
        /// </summary>
        public const int OBJECT = 19;

        /// <summary>
        /// In a Close button
        /// </summary>
        public const int CLOSE = 20;

        /// <summary>
        /// In a Help button
        /// </summary>
        public const int HELP = 21;
    }
}
