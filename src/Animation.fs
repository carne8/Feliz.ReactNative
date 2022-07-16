module Feliz.ReactNative.Animation

open Fable.Core
open Fable.Core.JsInterop
open Feliz.ReactNative

let inline getFunctionOf object functionName = object?(functionName)
let inline animatedFunc (functionName: string) : _ = getFunctionOf (import "Animated" "react-native") functionName
let inline easingFunc (functionName: string) : _ = getFunctionOf (import "Easing" "react-native") functionName


type AnimValue = float
type AnimEvent = interface end
type AnimFunc =
    abstract member start: unit -> unit
    abstract member start: callback: (obj -> unit) -> unit
    abstract member stop: unit -> unit
    abstract member reset: unit -> unit
    abstract member interpolate: {| inputRange: float []; outputRange: float [] |} -> AnimValue
    abstract member interpolate: {| inputRange: string []; outputRange: string [] |} -> AnimValue


type IEasing = interface end
[<Erase>]
type Easing =
    static member inline step0 (value: float) = unbox<IEasing> (easingFunc "step0" value)
    static member inline step1 (value: float) = unbox<IEasing> (easingFunc "step1" value)

    static member inline back () = unbox<IEasing> (easingFunc "back")
    static member inline back (value: float) = unbox<IEasing> (easingFunc "back" value)
    static member inline bounce () = unbox<IEasing> (easingFunc "bounce")
    static member inline bounce (value: float) = unbox<IEasing> (easingFunc "bounce" value)
    static member inline ease () = unbox<IEasing> (easingFunc "ease")
    static member inline ease (value: float) = unbox<IEasing> (easingFunc "ease" value)
    static member inline elastic () = unbox<IEasing> (easingFunc "elastic")
    static member inline elastic (value: float) = unbox<IEasing> (easingFunc "elastic" value)
    static member inline linear () = unbox<IEasing> (easingFunc "linear")
    static member inline linear (value: float) = unbox<IEasing> (easingFunc "linear" value)
    static member inline quad () = unbox<IEasing> (easingFunc "quad")
    static member inline quad (value: float) = unbox<IEasing> (easingFunc "quad" value)
    static member inline cubic () = unbox<IEasing> (easingFunc "cubic")
    static member inline cubic (value: float) = unbox<IEasing> (easingFunc "cubic" value)
    static member inline poly () = unbox<IEasing> (easingFunc "poly")
    static member inline poly (value: float) = unbox<IEasing> (easingFunc "poly" value)
    static member inline bezier (x1: float, y1: float, x2: float, y2: float) = unbox<IEasing> (easingFunc "bezier" x1 y1 x2 y2)
    static member inline circle () = unbox<IEasing> (easingFunc "circle")
    static member inline circle (value: float) = unbox<IEasing> (easingFunc "circle" value)
    static member inline sin () = unbox<IEasing> (easingFunc "sin")
    static member inline sin (value: float) = unbox<IEasing> (easingFunc "sin" value)
    static member inline exp () = unbox<IEasing> (easingFunc "exp")
    static member inline exp (value: float) = unbox<IEasing> (easingFunc "exp" value)

    static member inline in' (value: IEasing) = unbox<IEasing> (easingFunc "in" value)
    static member inline inOut (value: IEasing) = unbox<IEasing> (easingFunc "inOut" value)
    static member inline out (value: IEasing) = unbox<IEasing> (easingFunc "out" value)


type IAnimConfigProp = interface end
type animConfigProp =
    static member inline bounciness (value: float) = unbox<IAnimConfigProp> ("bounciness", value)
    static member inline damping (value: float) = unbox<IAnimConfigProp> ("damping", value)
    static member inline deceleration (value: float) = unbox<IAnimConfigProp> ("deceleration", value)
    static member inline delay (value: float) = unbox<IAnimConfigProp> ("delay", value)
    static member inline duration (value: float) = unbox<IAnimConfigProp> ("duration", value)
    static member inline friction (value: float) = unbox<IAnimConfigProp> ("friction", value)
    static member inline isInteraction (value: bool) = unbox<IAnimConfigProp> ("isInteraction", value)
    static member inline mass (value: float) = unbox<IAnimConfigProp> ("mass", value)
    static member inline overshootClamping (value: bool) = unbox<IAnimConfigProp> ("overshootClamping", value)
    static member inline overshootTension (value: float) = unbox<IAnimConfigProp> ("overshootTension", value)
    static member inline restDisplacementThreshold (value: float) = unbox<IAnimConfigProp> ("restDisplacementThreshold", value)
    static member inline restSpeedThreshold (value: float) = unbox<IAnimConfigProp> ("restSpeedThreshold", value)
    static member inline speed (value: float) = unbox<IAnimConfigProp> ("speed", value)
    static member inline stiffness (value: float) = unbox<IAnimConfigProp> ("stiffness", value)
    static member inline tension (value: float) = unbox<IAnimConfigProp> ("tension", value)
    static member inline toValue (value: float) = unbox<IAnimConfigProp> ("toValue", value)
    static member inline useNativeDriver (value: bool) = unbox<IAnimConfigProp> ("useNativeDriver", value)
    static member inline velocity (value: float) = unbox<IAnimConfigProp> ("velocity", value)
    static member inline easing (value: IEasing) = unbox<IAnimConfigProp> ("easing", value)


type IAnimComposeProp = interface end
type animComposeProp =
    static member inline iterations (value: int) = unbox<IAnimComposeProp> ("iterations", value)
    static member inline isInteraction (value: bool) = unbox<IAnimComposeProp> ("isInteraction", value)
    static member inline useNativeDriver (value: bool) = unbox<IAnimComposeProp> ("useNativeDriver", value)
    static member inline listener (value: (obj -> unit) -> unit) = unbox<IAnimComposeProp> ("listener", value)
    static member inline stopTogether (value: bool) = unbox<IAnimComposeProp> ("stopTogether", value)


[<Erase>]
type Animated =
    static member inline value (value: float) : AnimValue = unbox createNew (animatedFunc "Value") value
    static member inline valueXY (value: float) : AnimValue = unbox createNew (animatedFunc "ValueXY") value

    static member inline decay (animation: AnimValue) : AnimFunc = animatedFunc "decay" animation
    static member inline timing (animation: AnimValue) : AnimFunc = animatedFunc "timing" animation
    static member inline spring (animation: AnimValue) : AnimFunc = animatedFunc "spring" animation
    static member inline decay (animation: AnimValue, config: seq<IAnimConfigProp>) : AnimFunc = animatedFunc "decay" animation (createObj !!config)
    static member inline timing (animation: AnimValue, config: seq<IAnimConfigProp>) : AnimFunc = animatedFunc "timing" animation (createObj !!config)
    static member inline spring (animation: AnimValue, config: seq<IAnimConfigProp>) : AnimFunc = animatedFunc "spring" animation (createObj !!config)

    static member inline delay (ms: int) : AnimFunc = animatedFunc "delay" ms
    static member inline parallel' (animations: AnimFunc []) : AnimFunc = animatedFunc "parallel" animations
    static member inline parallel' (animations: AnimFunc [], config: seq<IAnimComposeProp>) : AnimFunc = animatedFunc "parallel" animations (createObj !!config)
    static member inline sequence (animations: AnimFunc []) : AnimFunc = animatedFunc "sequence" animations
    static member inline stagger (ms: int) (animations: AnimFunc []) : AnimFunc = animatedFunc "stagger" ms animations

    static member inline add (a: AnimValue) (b: AnimValue) : AnimValue = animatedFunc "add" a b
    static member inline subtract (a: AnimValue) (b: AnimValue) : AnimValue = animatedFunc "subtract" a b
    static member inline divide (a: AnimValue) (b: AnimValue) : AnimValue = animatedFunc "divide" a b
    static member inline modulo (a: AnimValue) (b: AnimValue) : AnimValue = animatedFunc "modulo" a b
    static member inline multiply (a: AnimValue) (b: AnimValue) : AnimValue = animatedFunc "multiply" a b
    static member inline diffClamp (a: AnimValue) (b: float) (c: float) : AnimValue = animatedFunc "diffClamp" a b c

    static member inline event (listeners: _ []) : AnimEvent = animatedFunc "event" listeners
    static member inline event (events: _ [], config: seq<IAnimComposeProp>) : AnimEvent = animatedFunc "event" events (createObj !!config)
    static member inline loop (animation: AnimValue) : AnimFunc = animatedFunc "loop" animation
    static member inline loop (animation: AnimValue, config: seq<IAnimComposeProp>) : AnimFunc = animatedFunc "loop" animation (createObj !!config)

    static member inline forkEvent (event: AnimEvent) (listener: _ -> unit) = animatedFunc "forkEvent" event listener
    static member inline unforkEvent (event: AnimEvent) (listener: _ -> unit) = animatedFunc "unforkEvent" event listener


[<Erase>]
type Comp =
    static member inline viewAnimated = Interop.createNativeElement "Animated.View"
    static member inline imageAnimated = Interop.createNativeElement "Animated.Image"
    static member inline textAnimated = Interop.createNativeElement "Animated.Text"
    static member inline scrollViewAnimated = Interop.createNativeElement "Animated.ScrollView"
    static member inline flatListAnimated = Interop.createNativeElement "Animated.FlatList"
    static member inline sectionListAnimated = Interop.createNativeElement "Animated.SectionList"

[<AutoOpen>]
module Helpers =
    type IInterpolateConfig = interface end
    [<Erase>]
    type interpolateConfig =
        static member inline inputRange (value: seq<float>) = unbox<IInterpolateConfig> ("inputRange", value)
        static member inline outputRange (value: seq<float>) = unbox<IInterpolateConfig> ("outputRange", value)
        static member inline easing (value: IEasing) = unbox<IInterpolateConfig> ("easing", value)

    [<Erase>]
    module interpolateConfig =
        [<Erase>]
        type extrapolate =
            static member inline extend = unbox<IInterpolateConfig> ("extrapolate", "extend")
            static member inline identity = unbox<IInterpolateConfig> ("extrapolate", "identity")
            static member inline clamp = unbox<IInterpolateConfig> ("extrapolate", "clamp")
        [<Erase>]
        type extrapolateLeft =
            static member inline left = unbox<IInterpolateConfig> ("extrapolateLeft", "left")
            static member inline identity = unbox<IInterpolateConfig> ("extrapolateLeft", "identity")
            static member inline clamp = unbox<IInterpolateConfig> ("extrapolateLeft", "clamp")
        [<Erase>]
        type extrapolateRight =
            static member inline right = unbox<IInterpolateConfig> ("extrapolateRight", "right")
            static member inline identity = unbox<IInterpolateConfig> ("extrapolateRight", "identity")
            static member inline clamp = unbox<IInterpolateConfig> ("extrapolateRight", "clamp")


    let inline getX (animationValue: AnimValue) = animationValue?x
    let inline getY (animationValue: AnimValue) = animationValue?y

    let inline setValue (newValue: float) (animation: AnimValue) : unit = animation?setValue newValue
    let inline setOffset (offset: float) (animation: AnimValue) : unit = animation?setOffset offset
    let inline flattenOffset (animation: AnimValue) : unit = animation?flattenOffset()
    let inline extractOffset (animation: AnimValue) : unit = animation?extractOffset()
    let inline addListener (callback: {| value: AnimValue |} -> unit) (animation: AnimValue) : string = animation?addListener callback
    let inline removeListener (id: string) (animation: AnimValue) : unit = animation?removeListener id
    let inline removeAllListeners (animation: AnimValue) : unit = animation?removeAllListeners()
    let inline stopAnimation (animation: AnimValue) : unit = animation?stopAnimation()
    let inline stopAnimation' (callback: {| value: AnimValue |} -> unit) (animation: AnimValue) : unit = animation?stopAnimation callback
    let inline resetAnimation (animation: AnimValue) : unit = animation?resetAnimation()
    let inline resetAnimation' (callback: {| value: AnimValue |} -> unit) (animation: AnimValue) : unit = animation?resetAnimation callback
    let inline interpolate (config: seq<IInterpolateConfig>) (animation: AnimValue) : AnimValue = animation?interpolate (createObj !!config)
    let inline getLayout (animation: AnimValue) : {| left: float; top: float |} = animation?getLayout()
    let inline getTranslateTransform (animation: AnimValue) : ITransform = animation?getTranslateTransform()