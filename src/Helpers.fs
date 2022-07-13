namespace Feliz.ReactNative

open Fable.Core.JsInterop

type ReactComponent = Feliz.ReactComponentAttribute

[<AutoOpen>]
module React =
    type ColorScheme =
        | Light
        | Dark
        | Unspecified

    let useColorScheme () =
        match (import "useColorScheme" "react-native")() with
        | "light" -> Light
        | "dark" -> Dark
        | _ -> Unspecified