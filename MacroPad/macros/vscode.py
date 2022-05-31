from adafruit_hid.consumer_control_code import ConsumerControlCode
from adafruit_hid.keycode import Keycode # REQUIRED if using Keycode.* values

app = {               # REQUIRED dict, must be named 'app'
    'name' : 'Code', # Application name
    'exec' : ['code.exe'], # Executable names
    'macros' : [      # List of button macros...
        # COLOR    LABEL    KEY SEQUENCE
        # 1st row ----------
        (0x000020, 'Over', [Keycode.F10]),
        (0x000020, 'Into', [Keycode.F11]),
        (0x000020, 'Out', [Keycode.SHIFT, Keycode.F11, -Keycode.SHIFT]),
        # 2nd row ----------
        (0x002000, 'Run', [Keycode.F5]),
        (0x002020, 'Pause', [Keycode.F6]),
        (0x200000, 'Stop', [Keycode.SHIFT, Keycode.F5, -Keycode.SHIFT]),
        # 3rd row ----------
        (0x000000, '', []),
        (0x000000, '', []),
        (0x000000, '', []),
        # 4th row ----------
        (0x000000, '', []),
        (0x000000, '', []),
        (0x000000, '', []),
        # Encoder button ---
        (0x000000, '', [])
    ]
}
