from adafruit_hid.consumer_control_code import ConsumerControlCode
from adafruit_hid.keycode import Keycode # REQUIRED if using Keycode.* values

app = {               # REQUIRED dict, must be named 'app'
    'name' : 'Clion', # Application name
    'exec' : ['clion64.exe'], # Executable names
    'macros' : [      # List of button macros...
        # COLOR    LABEL    KEY SEQUENCE
        # 1st row ----------
        (0x000020, 'Over', [Keycode.F8]),
        (0x000020, 'Into', [Keycode.F7]),
        (0x000020, 'Out', [Keycode.SHIFT, Keycode.F8, -Keycode.SHIFT]),
        # 2nd row ----------
        (0x002000, 'Run', [Keycode.SHIFT, Keycode.F9, -Keycode.SHIFT]),
        (0x002020, 'Resume', [Keycode.F9]),
        (0x200000, 'Stop', [Keycode.CONTROL, Keycode.F2, -Keycode.CONTROL]),
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
