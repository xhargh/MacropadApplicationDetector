# SPDX-FileCopyrightText: 2021 Phillip Burgess for Adafruit Industries
#
# SPDX-License-Identifier: MIT

# MACROPAD Hotkeys example: Microsoft Edge web browser for Windows

from adafruit_hid.keycode import Keycode # REQUIRED if using Keycode.* values

app = {                        # REQUIRED dict, must be named 'app'
    'name' : 'Windows Firefox', # Application name
    'exec' : 'firefox.exe',
    'macros' : [             # List of button macros...
        # COLOR    LABEL    KEY SEQUENCE
        # 1st row ----------
        (0x002000, '< Back', [Keycode.ALT, Keycode.LEFT_ARROW]),
        (0x002000, 'Fwd >',  [Keycode.ALT, Keycode.RIGHT_ARROW]),
        (0x200000, 'Up',     [Keycode.PAGE_UP]),      # Scroll up
        # 2nd row ----------
        (0x101000, '- Size', [Keycode.CONTROL, Keycode.KEYPAD_MINUS]),
        (0x101000, 'Size +', [Keycode.CONTROL, Keycode.KEYPAD_PLUS]),
        (0x200000, 'Down',   [Keycode.PAGE_DOWN]),                     # Scroll down
        # 3rd row ----------
        (0x000020, 'Reload',  [Keycode.CONTROL, 'r']),
        (0x000020, 'Home',    [Keycode.ALT, Keycode.HOME]),
        (0x000020, 'Private', [Keycode.CONTROL, 'N']),
        # 4th row ----------
        (0x101000, '< Tab', [Keycode.CONTROL, Keycode.SHIFT, Keycode.TAB]),
        (0x101000, 'Tab >', [Keycode.CONTROL, Keycode.TAB]),
        (0x080808, 'Full', [Keycode.F11]),
        # Encoder button ---
        (0x000000, '', [Keycode.CONTROL, 'w']) # Close tab
    ]
}
