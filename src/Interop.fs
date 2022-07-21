namespace Feliz.ReactNative

open Feliz
open Fable.Core.JsInterop

[<RequireQualifiedAccess>]
module Interop =
    let createElement (_element: obj) (_props: obj) : ReactElement = import "createElement" "react"

    let inline createElementFromName (name: string) (properties: IReactProperty list) : ReactElement =
        createElement (import name "react-native") (createObj !!properties)

    let inline createElementFromNameWithChildren (name: string) (children: seq<ReactElement>) =
        createElement (import name "react-native") (createObj [ "children", Interop.reactApi.Children.toArray (Array.ofSeq children) ])