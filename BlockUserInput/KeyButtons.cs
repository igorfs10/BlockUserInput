namespace BlockUserInput
{
    public class KeyButtons
    {
        //
        // Summary:
        //     Get all mapped keys value;
        public static int[] GetAllKeys()
        {
            int[] Allkeys = new int[259];
            for (int i = 1; i < 255; ++i)
            {
                Allkeys[i - 1] = i;
            }
            Allkeys[255] = 65535;
            Allkeys[256] = 65536;
            Allkeys[257] = 131072;
            Allkeys[258] = 262144;
            return Allkeys;
        }
        //
        // Summary:
        //     The bitmask to extract modifiers from a key value.
        public const int Modifiers = -65536;
        //
        // Summary:
        //     No key pressed.
        public const int None = 0;
        //
        // Summary:
        //     The left mouse button.
        public const int LButton = 1;
        //
        // Summary:
        //     The right mouse button.
        public const int RButton = 2;
        //
        // Summary:
        //     The CANCEL key.
        public const int Cancel = 3;
        //
        // Summary:
        //     The middle mouse button (three-button mouse).
        public const int MButton = 4;
        //
        // Summary:
        //     The first x mouse button (five-button mouse).
        public const int XButton1 = 5;
        //
        // Summary:
        //     The second x mouse button (five-button mouse).
        public const int XButton2 = 6;
        //
        // Summary:
        //     The BACKSPACE key.
        public const int Back = 8;
        //
        // Summary:
        //     The TAB key.
        public const int Tab = 9;
        //
        // Summary:
        //     The LINEFEED key.
        public const int LineFeed = 10;
        //
        // Summary:
        //     The CLEAR key.
        public const int Clear = 12;
        //
        // Summary:
        //     The RETURN key.
        public const int Return = 13;
        //
        // Summary:
        //     The ENTER key.
        public const int Enter = 13;
        //
        // Summary:
        //     The SHIFT key.
        public const int ShiftKey = 16;
        //
        // Summary:
        //     The CTRL key.
        public const int ControlKey = 17;
        //
        // Summary:
        //     The ALT key.
        public const int Menu = 18;
        //
        // Summary:
        //     The PAUSE key.
        public const int Pause = 19;
        //
        // Summary:
        //     The CAPS LOCK key.
        public const int Capital = 20;
        //
        // Summary:
        //     The CAPS LOCK key.
        public const int CapsLock = 20;
        //
        // Summary:
        //     The IME Kana mode key.
        public const int KanaMode = 21;
        //
        // Summary:
        //     The IME Hanguel mode key. (maintained for compatibility; use HangulMode)
        public const int HanguelMode = 21;
        //
        // Summary:
        //     The IME Hangul mode key.
        public const int HangulMode = 21;
        //
        // Summary:
        //     The IME Junja mode key.
        public const int JunjaMode = 23;
        //
        // Summary:
        //     The IME final mode key.
        public const int FinalMode = 24;
        //
        // Summary:
        //     The IME Hanja mode key.
        public const int HanjaMode = 25;
        //
        // Summary:
        //     The IME Kanji mode key.
        public const int KanjiMode = 25;
        //
        // Summary:
        //     The ESC key.
        public const int Escape = 27;
        //
        // Summary:
        //     The IME convert key.
        public const int IMEConvert = 28;
        //
        // Summary:
        //     The IME nonconvert key.
        public const int IMENonconvert = 29;
        //
        // Summary:
        //     The IME accept key; replaces System.Windows.Forms.Keys.IMEAceept.
        public const int IMEAccept = 30;
        //
        // Summary:
        //     The IME accept key. Obsolete; use System.Windows.Forms.Keys.IMEAccept instead.
        public const int IMEAceept = 30;
        //
        // Summary:
        //     The IME mode change key.
        public const int IMEModeChange = 31;
        //
        // Summary:
        //     The SPACEBAR key.
        public const int Space = 32;
        //
        // Summary:
        //     The PAGE UP key.
        public const int Prior = 33;
        //
        // Summary:
        //     The PAGE UP key.
        public const int PageUp = 33;
        //
        // Summary:
        //     The PAGE DOWN key.
        public const int Next = 34;
        //
        // Summary:
        //     The PAGE DOWN key.
        public const int PageDown = 34;
        //
        // Summary:
        //     The END key.
        public const int End = 35;
        //
        // Summary:
        //     The HOME key.
        public const int Home = 36;
        //
        // Summary:
        //     The LEFT ARROW key.
        public const int Left = 37;
        //
        // Summary:
        //     The UP ARROW key.
        public const int Up = 38;
        //
        // Summary:
        //     The RIGHT ARROW key.
        public const int Right = 39;
        //
        // Summary:
        //     The DOWN ARROW key.
        public const int Down = 40;
        //
        // Summary:
        //     The SELECT key.
        public const int Select = 41;
        //
        // Summary:
        //     The PRINT key.
        public const int Print = 42;
        //
        // Summary:
        //     The EXECUTE key.
        public const int Execute = 43;
        //
        // Summary:
        //     The PRINT SCREEN key.
        public const int Snapshot = 44;
        //
        // Summary:
        //     The PRINT SCREEN key.
        public const int PrintScreen = 44;
        //
        // Summary:
        //     The INS key.
        public const int Insert = 45;
        //
        // Summary:
        //     The DEL key.
        public const int Delete = 46;
        //
        // Summary:
        //     The HELP key.
        public const int Help = 47;
        //
        // Summary:
        //     The 0 key.
        public const int D0 = 48;
        //
        // Summary:
        //     The 1 key.
        public const int D1 = 49;
        //
        // Summary:
        //     The 2 key.
        public const int D2 = 50;
        //
        // Summary:
        //     The 3 key.
        public const int D3 = 51;
        //
        // Summary:
        //     The 4 key.
        public const int D4 = 52;
        //
        // Summary:
        //     The 5 key.
        public const int D5 = 53;
        //
        // Summary:
        //     The 6 key.
        public const int D6 = 54;
        //
        // Summary:
        //     The 7 key.
        public const int D7 = 55;
        //
        // Summary:
        //     The 8 key.
        public const int D8 = 56;
        //
        // Summary:
        //     The 9 key.
        public const int D9 = 57;
        //
        // Summary:
        //     The A key.
        public const int A = 65;
        //
        // Summary:
        //     The B key.
        public const int B = 66;
        //
        // Summary:
        //     The C key.
        public const int C = 67;
        //
        // Summary:
        //     The D key.
        public const int D = 68;
        //
        // Summary:
        //     The E key.
        public const int E = 69;
        //
        // Summary:
        //     The F key.
        public const int F = 70;
        //
        // Summary:
        //     The G key.
        public const int G = 71;
        //
        // Summary:
        //     The H key.
        public const int H = 72;
        //
        // Summary:
        //     The I key.
        public const int I = 73;
        //
        // Summary:
        //     The J key.
        public const int J = 74;
        //
        // Summary:
        //     The K key.
        public const int K = 75;
        //
        // Summary:
        //     The L key.
        public const int L = 76;
        //
        // Summary:
        //     The M key.
        public const int M = 77;
        //
        // Summary:
        //     The N key.
        public const int N = 78;
        //
        // Summary:
        //     The O key.
        public const int O = 79;
        //
        // Summary:
        //     The P key.
        public const int P = 80;
        //
        // Summary:
        //     The Q key.
        public const int Q = 81;
        //
        // Summary:
        //     The R key.
        public const int R = 82;
        //
        // Summary:
        //     The S key.
        public const int S = 83;
        //
        // Summary:
        //     The T key.
        public const int T = 84;
        //
        // Summary:
        //     The U key.
        public const int U = 85;
        //
        // Summary:
        //     The V key.
        public const int V = 86;
        //
        // Summary:
        //     The W key.
        public const int W = 87;
        //
        // Summary:
        //     The X key.
        public const int X = 88;
        //
        // Summary:
        //     The Y key.
        public const int Y = 89;
        //
        // Summary:
        //     The Z key.
        public const int Z = 90;
        //
        // Summary:
        //     The left Windows logo key (Microsoft Natural Keyboard).
        public const int LWin = 91;
        //
        // Summary:
        //     The right Windows logo key (Microsoft Natural Keyboard).
        public const int RWin = 92;
        //
        // Summary:
        //     The application key (Microsoft Natural Keyboard).
        public const int Apps = 93;
        //
        // Summary:
        //     The computer sleep key.
        public const int Sleep = 95;
        //
        // Summary:
        //     The 0 key on the numeric keypad.
        public const int NumPad0 = 96;
        //
        // Summary:
        //     The 1 key on the numeric keypad.
        public const int NumPad1 = 97;
        //
        // Summary:
        //     The 2 key on the numeric keypad.
        public const int NumPad2 = 98;
        //
        // Summary:
        //     The 3 key on the numeric keypad.
        public const int NumPad3 = 99;
        //
        // Summary:
        //     The 4 key on the numeric keypad.
        public const int NumPad4 = 100;
        //
        // Summary:
        //     The 5 key on the numeric keypad.
        public const int NumPad5 = 101;
        //
        // Summary:
        //     The 6 key on the numeric keypad.
        public const int NumPad6 = 102;
        //
        // Summary:
        //     The 7 key on the numeric keypad.
        public const int NumPad7 = 103;
        //
        // Summary:
        //     The 8 key on the numeric keypad.
        public const int NumPad8 = 104;
        //
        // Summary:
        //     The 9 key on the numeric keypad.
        public const int NumPad9 = 105;
        //
        // Summary:
        //     The multiply key.
        public const int Multiply = 106;
        //
        // Summary:
        //     The add key.
        public const int Add = 107;
        //
        // Summary:
        //     The separator key.
        public const int Separator = 108;
        //
        // Summary:
        //     The subtract key.
        public const int Subtract = 109;
        //
        // Summary:
        //     The decimal key.
        public const int Decimal = 110;
        //
        // Summary:
        //     The divide key.
        public const int Divide = 111;
        //
        // Summary:
        //     The F1 key.
        public const int F1 = 112;
        //
        // Summary:
        //     The F2 key.
        public const int F2 = 113;
        //
        // Summary:
        //     The F3 key.
        public const int F3 = 114;
        //
        // Summary:
        //     The F4 key.
        public const int F4 = 115;
        //
        // Summary:
        //     The F5 key.
        public const int F5 = 116;
        //
        // Summary:
        //     The F6 key.
        public const int F6 = 117;
        //
        // Summary:
        //     The F7 key.
        public const int F7 = 118;
        //
        // Summary:
        //     The F8 key.
        public const int F8 = 119;
        //
        // Summary:
        //     The F9 key.
        public const int F9 = 120;
        //
        // Summary:
        //     The F10 key.
        public const int F10 = 121;
        //
        // Summary:
        //     The F11 key.
        public const int F11 = 122;
        //
        // Summary:
        //     The F12 key.
        public const int F12 = 123;
        //
        // Summary:
        //     The F13 key.
        public const int F13 = 124;
        //
        // Summary:
        //     The F14 key.
        public const int F14 = 125;
        //
        // Summary:
        //     The F15 key.
        public const int F15 = 126;
        //
        // Summary:
        //     The F16 key.
        public const int F16 = 127;
        //
        // Summary:
        //     The F17 key.
        public const int F17 = 128;
        //
        // Summary:
        //     The F18 key.
        public const int F18 = 129;
        //
        // Summary:
        //     The F19 key.
        public const int F19 = 130;
        //
        // Summary:
        //     The F20 key.
        public const int F20 = 131;
        //
        // Summary:
        //     The F21 key.
        public const int F21 = 132;
        //
        // Summary:
        //     The F22 key.
        public const int F22 = 133;
        //
        // Summary:
        //     The F23 key.
        public const int F23 = 134;
        //
        // Summary:
        //     The F24 key.
        public const int F24 = 135;
        //
        // Summary:
        //     The NUM LOCK key.
        public const int NumLock = 144;
        //
        // Summary:
        //     The SCROLL LOCK key.
        public const int Scroll = 145;
        //
        // Summary:
        //     The left SHIFT key.
        public const int LShiftKey = 160;
        //
        // Summary:
        //     The right SHIFT key.
        public const int RShiftKey = 161;
        //
        // Summary:
        //     The left CTRL key.
        public const int LControlKey = 162;
        //
        // Summary:
        //     The right CTRL key.
        public const int RControlKey = 163;
        //
        // Summary:
        //     The left ALT key.
        public const int LMenu = 164;
        //
        // Summary:
        //     The right ALT key.
        public const int RMenu = 165;
        //
        // Summary:
        //     The browser back key (Windows 2000 or later).
        public const int BrowserBack = 166;
        //
        // Summary:
        //     The browser forward key (Windows 2000 or later).
        public const int BrowserForward = 167;
        //
        // Summary:
        //     The browser refresh key (Windows 2000 or later).
        public const int BrowserRefresh = 168;
        //
        // Summary:
        //     The browser stop key (Windows 2000 or later).
        public const int BrowserStop = 169;
        //
        // Summary:
        //     The browser search key (Windows 2000 or later).
        public const int BrowserSearch = 170;
        //
        // Summary:
        //     The browser favorites key (Windows 2000 or later).
        public const int BrowserFavorites = 171;
        //
        // Summary:
        //     The browser home key (Windows 2000 or later).
        public const int BrowserHome = 172;
        //
        // Summary:
        //     The volume mute key (Windows 2000 or later).
        public const int VolumeMute = 173;
        //
        // Summary:
        //     The volume down key (Windows 2000 or later).
        public const int VolumeDown = 174;
        //
        // Summary:
        //     The volume up key (Windows 2000 or later).
        public const int VolumeUp = 175;
        //
        // Summary:
        //     The media next track key (Windows 2000 or later).
        public const int MediaNextTrack = 176;
        //
        // Summary:
        //     The media previous track key (Windows 2000 or later).
        public const int MediaPreviousTrack = 177;
        //
        // Summary:
        //     The media Stop key (Windows 2000 or later).
        public const int MediaStop = 178;
        //
        // Summary:
        //     The media play pause key (Windows 2000 or later).
        public const int MediaPlayPause = 179;
        //
        // Summary:
        //     The launch mail key (Windows 2000 or later).
        public const int LaunchMail = 180;
        //
        // Summary:
        //     The select media key (Windows 2000 or later).
        public const int SelectMedia = 181;
        //
        // Summary:
        //     The start application one key (Windows 2000 or later).
        public const int LaunchApplication1 = 182;
        //
        // Summary:
        //     The start application two key (Windows 2000 or later).
        public const int LaunchApplication2 = 183;
        //
        // Summary:
        //     The OEM Semicolon key on a US standard keyboard (Windows 2000 or later).
        public const int OemSemicolon = 186;
        //
        // Summary:
        //     The OEM 1 key.
        public const int Oem1 = 186;
        //
        // Summary:
        //     The OEM plus key on any country/region keyboard (Windows 2000 or later).
        public const int Oemplus = 187;
        //
        // Summary:
        //     The OEM comma key on any country/region keyboard (Windows 2000 or later).
        public const int Oemcomma = 188;
        //
        // Summary:
        //     The OEM minus key on any country/region keyboard (Windows 2000 or later).
        public const int OemMinus = 189;
        //
        // Summary:
        //     The OEM period key on any country/region keyboard (Windows 2000 or later).
        public const int OemPeriod = 190;
        //
        // Summary:
        //     The OEM question mark key on a US standard keyboard (Windows 2000 or later).
        public const int OemQuestion = 191;
        //
        // Summary:
        //     The OEM 2 key.
        public const int Oem2 = 191;
        //
        // Summary:
        //     The OEM tilde key on a US standard keyboard (Windows 2000 or later).
        public const int Oemtilde = 192;
        //
        // Summary:
        //     The OEM 3 key.
        public const int Oem3 = 192;
        //
        // Summary:
        //     The OEM open bracket key on a US standard keyboard (Windows 2000 or later).
        public const int OemOpenBrackets = 219;
        //
        // Summary:
        //     The OEM 4 key.
        public const int Oem4 = 219;
        //
        // Summary:
        //     The OEM pipe key on a US standard keyboard (Windows 2000 or later).
        public const int OemPipe = 220;
        //
        // Summary:
        //     The OEM 5 key.
        public const int Oem5 = 220;
        //
        // Summary:
        //     The OEM close bracket key on a US standard keyboard (Windows 2000 or later).
        public const int OemCloseBrackets = 221;
        //
        // Summary:
        //     The OEM 6 key.
        public const int Oem6 = 221;
        //
        // Summary:
        //     The OEM singled/double quote key on a US standard keyboard (Windows 2000 or later).
        public const int OemQuotes = 222;
        //
        // Summary:
        //     The OEM 7 key.
        public const int Oem7 = 222;
        //
        // Summary:
        //     The OEM 8 key.
        public const int Oem8 = 223;
        //
        // Summary:
        //     The OEM angle bracket or backslash key on the RT 102 key keyboard (Windows 2000
        //     or later).
        public const int OemBackslash = 226;
        //
        // Summary:
        //     The OEM 102 key.
        public const int Oem102 = 226;
        //
        // Summary:
        //     The PROCESS KEY key.
        public const int ProcessKey = 229;
        //
        // Summary:
        //     Used to pass Unicode characters as if they were keystrokes. The Packet key value
        //     is the low word of a 32-bit virtual-key value used for non-keyboard input methods.
        public const int Packet = 231;
        //
        // Summary:
        //     The ATTN key.
        public const int Attn = 246;
        //
        // Summary:
        //     The CRSEL key.
        public const int Crsel = 247;
        //
        // Summary:
        //     The EXSEL key.
        public const int Exsel = 248;
        //
        // Summary:
        //     The ERASE EOF key.
        public const int EraseEof = 249;
        //
        // Summary:
        //     The PLAY key.
        public const int Play = 250;
        //
        // Summary:
        //     The ZOOM key.
        public const int Zoom = 251;
        //
        // Summary:
        //     A constant reserved for future use.
        public const int NoName = 252;
        //
        // Summary:
        //     The PA1 key.
        public const int Pa1 = 253;
        //
        // Summary:
        //     The CLEAR key.
        public const int OemClear = 254;
        //
        // Summary:
        //     The bitmask to extract a key code from a key value.
        public const int KeyCode = 65535;
        //
        // Summary:
        //     The SHIFT modifier key.
        public const int Shift = 65536;
        //
        // Summary:
        //     The CTRL modifier key.
        public const int Control = 131072;
        //
        // Summary:
        //     The ALT modifier key.
        public const int Alt = 262144;
    }
}
