# MacroPad Automation and Application Detector

Have you ever pressed the wrong button on your [AdaFruit MacroPad](https://www.adafruit.com/product/5128)?
This is now a thing of the past with the new Macropad Application Detector!

## Macropad Application Detector

MacroPad Application Detector is a Windows application that detects
the currently active Window and send the executable's name to the Macropad
so it can automatically change to the appropriate macro.

This require the MacroPad to listen and react on input from
the SerialPort.

## How To

* Copy all files of the MacroPad folder to the MacroPad's flash disk.
* Run the MacroPad Application Detector, select the COM port and press Connect.
* Modify your macros on the MacroPad to fit the applications you are using.
  Normal MacroPad macros are compatible, but will not be changed to automatically.
  Add a ```exec``` config with the executable's name (lower case only) to your macro.
  ```python
    'name' : 'Numpad', # Application name
    'exec' : ['excel.exe', 'speedcrunch.exe'], # Executable names
  ```

## TODO
- [ ] Identify what is running inside ApplicationFrameHost.exe
- [ ] GitHub CI for automatic build of the Windows binary.
- [ ] Start minimized.
- [ ] Create an initial macro useful for grub and Bios
- [ ] Support for more OS:s than Windows.
- [ ] Detect OS and hide profiles for other OSes.

