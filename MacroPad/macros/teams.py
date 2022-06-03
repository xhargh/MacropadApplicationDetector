from adafruit_hid.consumer_control_code import ConsumerControlCode
from adafruit_hid.keycode import Keycode

app = {               # REQUIRED dict, must be named 'app'
    'name' : 'Teams', # Application name
    'exec' : ['teams.exe'], # Executable names
    'macros' : [      # List of button macros...
        # COLOR    LABEL    KEY SEQUENCE
        # 1st row ----------
        (0x000000, '', []),
        (0x300030, 'Hand', [Keycode.CONTROL, Keycode.SHIFT, 'k', -Keycode.SHIFT, -Keycode.CONTROL]),
        (0x000000, '', []),
        # 2nd row ----------
        (0x000000, '', []),
        (0x300000, 'ScreenShare', [Keycode.CONTROL, Keycode.SHIFT, 'e', -Keycode.SHIFT, -Keycode.CONTROL]),
        (0x000000, '', []),
        # 3rd row ----------
        (0x200000, 'VolMute', [[ConsumerControlCode.MUTE]]),
        (0x000000, '', []),
        (0x300000, 'MicMute', [Keycode.CONTROL, Keycode.SHIFT, 'm', -Keycode.SHIFT, -Keycode.CONTROL]),
        # 4th row ----------
        (0x202000, '', []),
        (0x003000, 'Cam', [Keycode.CONTROL, Keycode.SHIFT, 'o', -Keycode.SHIFT, -Keycode.CONTROL]),
        (0x202000, '', []),
        # Encoder button ---
        (0x000000, '', [])
    ]
}
