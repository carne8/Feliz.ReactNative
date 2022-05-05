namespace Feliz.ReactNative

open Fable.Core

type LayoutEvent =
    { layout: {| width: float; height: float; x: float; y: float |}
      target: float }

type PressEvent =
    { changedTouches: PressEvent []
      identifier: float
      locationX: float
      locationY: float
      pageX: float
      pageY: float
      target: float
      timestamp: float
      touches: PressEvent [] }

[<StringEnum; RequireQualifiedAccess>]
type AccessibilityRole =
    | Adjustable
    | Alert
    | Button
    | Checkbox
    | Combobox
    | Header
    | Image
    | Imagebutton
    | Keyboardkey
    | Link
    | Menu
    | Menubar
    | Menuitem
    | None
    | Progressbar
    | Radio
    | Radiogroup
    | Scrollbar
    | Search
    | Spinbutton
    | Summary
    | Switch
    | Tab
    | Tablist
    | Text
    | Timer
    | Togglebutton
    | Toolbar

type AccessibilityActions =
    { name: string
      label: string option }

type TextLayout =
    { capHeight: float
      ascender: float
      descender: float
      width: float
      height: float
      xHeight: float
      x: float
      y: float }

type TextLayoutEvent =
    { lines: TextLayout []
      target: float }

type Rect =
    { bottom: float option
      left: float option
      right: float option
      top: float option }