namespace Feliz.ReactNative

open Fable.Core.JsInterop

type ReactComponent = Feliz.ReactComponentAttribute

type ColorScheme =
    | Light
    | Dark
    | Unspecified

module React =
    let useColorScheme () =
        match (import "useColorScheme" "react-native")() with
        | "light" -> Light
        | "dark" -> Dark
        | _ -> Unspecified