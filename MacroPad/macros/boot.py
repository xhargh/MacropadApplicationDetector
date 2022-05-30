# Alt Numpad for grub and BIOS

from adafruit_hid.keycode import Keycode  # REQUIRED if using Keycode.* values

app = {  # REQUIRED dict, must be named 'app'
    'name': 'grub',  # Application name
    # 'exec' : ['grub'], # Executable names
    'macros': [  # List of button macros...
        # COLOR    LABEL    KEY SEQUENCE
        # 1st row ----------
        (0x202000, 'Home', [Keycode.HOME]),
        (0x202000, 'Up', [Keycode.UP_ARROW]),
        (0x202000, 'PgUp', [Keycode.PAGE_UP]),
        # 2nd row ----------
        (0x202000, 'Left', [Keycode.LEFT_ARROW]),
        (0x202000, 'Enter', [Keycode.ENTER]),
        (0x202000, 'Right', [Keycode.RIGHT_ARROW]),
        # 3rd row ----------
        (0x202000, 'End', [Keycode.END]),
        (0x202000, 'Down', [Keycode.DOWN_ARROW]),
        (0x202000, 'PgDn', [Keycode.PAGE_DOWN]),
        # 4th row ----------
        (0x101010, 'Del', [Keycode.DELETE]),
        (0x800000, 'F2', [Keycode.F2]),
        (0x101010, 'Enter', [Keycode.ENTER]),
        # Encoder button ---
        (0x000000, 'Esc', [Keycode.ESCAPE])
    ]
}
