module Feliz.ReactNative.Animation.NativeModule

open Fable.Core
open Fable.Core.JsInterop
open Feliz.ReactNative.Animation.Types

let inline private moduleAnimated () = import "Animated" "react-native"
let inline private moduleEasing () = import "Easing" "react-native"

/// This type represents the ``Animated`` module of react-native.
[<Erase>]
type Animated =
    static member inline value (value: float) : AnimValue = !!createNew (moduleAnimated?Value) value
    static member inline valueXY (value: float) : AnimValue = !!createNew (moduleAnimated?ValueXY) value

    static member inline decay (animation: AnimValue) (config: seq<IConfigProp>) : AnimFunc = moduleAnimated?decay (animation, (createObj !!config))
    static member inline timing (animation: AnimValue) (config: seq<IConfigProp>) : AnimFunc = moduleAnimated?timing (animation, (createObj !!config))
    static member inline spring (animation: AnimValue) (config: seq<IConfigProp>) : AnimFunc = moduleAnimated?spring (animation, (createObj !!config))

    static member inline delay (ms: int) : AnimFunc = moduleAnimated?delay ms
    static member inline parallel' (animations: seq<AnimFunc>) : AnimFunc = moduleAnimated?("parallel") animations
    static member inline parallel' (animations: seq<AnimFunc>, config: seq<IComposeProp>) : AnimFunc = moduleAnimated?("parallel") (animations, (createObj !!config))
    static member inline sequence (animations: seq<AnimFunc>) : AnimFunc = moduleAnimated?sequence animations
    static member inline stagger (ms: int) (animations: seq<AnimFunc>) : AnimFunc = moduleAnimated?stagger (ms, animations)

    static member inline add (a: AnimValue) (b: AnimValue) : AnimValue = moduleAnimated?add (a, b)
    static member inline subtract (a: AnimValue) (b: AnimValue) : AnimValue = moduleAnimated?subtract (a, b)
    static member inline divide (a: AnimValue) (b: AnimValue) : AnimValue = moduleAnimated?divide (a, b)
    static member inline modulo (a: AnimValue) (b: AnimValue) : AnimValue = moduleAnimated?modulo (a, b)
    static member inline multiply (a: AnimValue) (b: AnimValue) : AnimValue = moduleAnimated?multiply (a, b)
    static member inline diffClamp (a: AnimValue) (b: float) (c: float) : AnimValue = moduleAnimated?diffClamp (a, b, c)

    static member inline event (listeners: seq<_>) : _ -> AnimEvent = moduleAnimated?event listeners
    static member inline event (events: seq<_>, config: seq<IComposeProp>) : _ -> AnimEvent = moduleAnimated?event (events, (createObj !!config))
    static member inline loop (animation: AnimValue) : AnimFunc = moduleAnimated?loop animation
    static member inline loop (animation: AnimValue, config: seq<IComposeProp>) : AnimFunc = moduleAnimated?loop (animation, (createObj !!config))

    static member inline forkEvent (event: AnimEvent) (listener: _ -> unit) = moduleAnimated?forkEvent event listener
    static member inline unforkEvent (event: AnimEvent) (listener: _ -> unit) = moduleAnimated?unforkEvent event listener


/// This type represents the ``Easing`` module of react-native.
[<Erase>]
type Easing =
    static member inline step0 (value: float) = unbox<IEasing> (moduleEasing?step0 value)
    static member inline step1 (value: float) = unbox<IEasing> (moduleEasing?step1 value)

    static member inline back () = unbox<IEasing> (moduleEasing?back)
    static member inline back (value: float) = unbox<IEasing> (moduleEasing?back value)
    static member inline bounce () = unbox<IEasing> (moduleEasing?bounce)
    static member inline bounce (value: float) = unbox<IEasing> (moduleEasing?bounce value)
    static member inline ease () = unbox<IEasing> (moduleEasing?ease)
    static member inline ease (value: float) = unbox<IEasing> (moduleEasing?ease value)
    static member inline elastic () = unbox<IEasing> (moduleEasing?elastic)
    static member inline elastic (value: float) = unbox<IEasing> (moduleEasing?elastic value)
    static member inline linear () = unbox<IEasing> (moduleEasing?linear)
    static member inline linear (value: float) = unbox<IEasing> (moduleEasing?linear value)
    static member inline quad () = unbox<IEasing> (moduleEasing?quad)
    static member inline quad (value: float) = unbox<IEasing> (moduleEasing?quad value)
    static member inline cubic () = unbox<IEasing> (moduleEasing?cubic)
    static member inline cubic (value: float) = unbox<IEasing> (moduleEasing?cubic value)
    static member inline poly () = unbox<IEasing> (moduleEasing?poly)
    static member inline poly (value: float) = unbox<IEasing> (moduleEasing?poly value)
    static member inline bezier (x1: float, y1: float, x2: float, y2: float) = unbox<IEasing> (moduleEasing?bezier x1 y1 x2 y2)
    static member inline circle () = unbox<IEasing> (moduleEasing?circle)
    static member inline circle (value: float) = unbox<IEasing> (moduleEasing?circle value)
    static member inline sin () = unbox<IEasing> (moduleEasing?sin)
    static member inline sin (value: float) = unbox<IEasing> (moduleEasing?sin value)
    static member inline exp () = unbox<IEasing> (moduleEasing?exp)
    static member inline exp (value: float) = unbox<IEasing> (moduleEasing?exp value)

    static member inline in' (value: IEasing) = unbox<IEasing> (moduleEasing?("in") value)
    static member inline inOut (value: IEasing) = unbox<IEasing> (moduleEasing?inOut value)
    static member inline out (value: IEasing) = unbox<IEasing> (moduleEasing?out value)