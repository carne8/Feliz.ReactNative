namespace Feliz.ReactNative

open Feliz
open Fable.Core
open Fable.React

[<Erase>]
type Comp =
    static member inline view props = Interop.createNativeElement "View" props
    static member inline view (children: seq<ReactElement>) = Interop.reactNativeElementWithChildren "View" children