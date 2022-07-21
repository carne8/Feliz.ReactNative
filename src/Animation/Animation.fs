namespace Feliz.ReactNative.Animation

open Fable.Core
open Fable.Core.JsInterop

open Feliz.ReactNative
open Feliz.ReactNative.Animation.Types
open Feliz.ReactNative.Animation.NativeModule


module animProp =
    [<Erase>]
    type config =
        static member inline bounciness (value: float) = unbox<IConfigProp> ("bounciness", value)
        static member inline damping (value: float) = unbox<IConfigProp> ("damping", value)
        static member inline deceleration (value: float) = unbox<IConfigProp> ("deceleration", value)
        static member inline delay (value: float) = unbox<IConfigProp> ("delay", value)
        static member inline duration (value: float) = unbox<IConfigProp> ("duration", value)
        static member inline friction (value: float) = unbox<IConfigProp> ("friction", value)
        static member inline isInteraction (value: bool) = unbox<IConfigProp> ("isInteraction", value)
        static member inline mass (value: float) = unbox<IConfigProp> ("mass", value)
        static member inline overshootClamping (value: bool) = unbox<IConfigProp> ("overshootClamping", value)
        static member inline overshootTension (value: float) = unbox<IConfigProp> ("overshootTension", value)
        static member inline restDisplacementThreshold (value: float) = unbox<IConfigProp> ("restDisplacementThreshold", value)
        static member inline restSpeedThreshold (value: float) = unbox<IConfigProp> ("restSpeedThreshold", value)
        static member inline speed (value: float) = unbox<IConfigProp> ("speed", value)
        static member inline stiffness (value: float) = unbox<IConfigProp> ("stiffness", value)
        static member inline tension (value: float) = unbox<IConfigProp> ("tension", value)
        static member inline toValue (value: float) = unbox<IConfigProp> ("toValue", value)
        static member inline useNativeDriver (value: bool) = unbox<IConfigProp> ("useNativeDriver", value)
        static member inline velocity (value: float) = unbox<IConfigProp> ("velocity", value)
        static member inline easing (value: IEasing) = unbox<IConfigProp> ("easing", value)

    [<Erase>]
    type compose =
        static member inline iterations (value: int) = unbox<IComposeProp> ("iterations", value)
        static member inline isInteraction (value: bool) = unbox<IComposeProp> ("isInteraction", value)
        static member inline useNativeDriver (value: bool) = unbox<IComposeProp> ("useNativeDriver", value)
        static member inline listener (value: (obj -> unit) -> unit) = unbox<IComposeProp> ("listener", value)
        static member inline stopTogether (value: bool) = unbox<IComposeProp> ("stopTogether", value)

    [<Erase>]
    type interpolateProp =
        static member inline inputRange (value: seq<float>) = unbox<IInterpolateProp> ("inputRange", value)
        static member inline outputRange (value: seq<float>) = unbox<IInterpolateProp> ("outputRange", value)
        static member inline easing (value: IEasing) = unbox<IInterpolateProp> ("easing", value)
    [<Erase>]
    module interpolateProp =
        [<Erase>]
        type extrapolate =
            static member inline extend = unbox<IInterpolateProp> ("extrapolate", "extend")
            static member inline identity = unbox<IInterpolateProp> ("extrapolate", "identity")
            static member inline clamp = unbox<IInterpolateProp> ("extrapolate", "clamp")
        [<Erase>]
        type extrapolateLeft =
            static member inline left = unbox<IInterpolateProp> ("extrapolateLeft", "left")
            static member inline identity = unbox<IInterpolateProp> ("extrapolateLeft", "identity")
            static member inline clamp = unbox<IInterpolateProp> ("extrapolateLeft", "clamp")
        [<Erase>]
        type extrapolateRight =
            static member inline right = unbox<IInterpolateProp> ("extrapolateRight", "right")
            static member inline identity = unbox<IInterpolateProp> ("extrapolateRight", "identity")
            static member inline clamp = unbox<IInterpolateProp> ("extrapolateRight", "clamp")


// This module contains many helpers for manipulating animations.
module Animation =
    /// Same as ``new Animated.Value(value)`` in JS.
    let inline create value = Animated.value value
    /// Same as ``new Animated.ValueXY(value)`` in JS.
    let inline createXY value = Animated.valueXY value

    let inline decay config animation = Animated.decay animation config
    let inline timing config animation = Animated.timing animation config
    let inline spring config animation = Animated.spring animation config

    let inline delay ms = Animated.delay ms
    let inline sequence animations = Animated.sequence animations
    let inline parallel' animations = Animated.parallel' animations
    let inline parallelCF config animations = Animated.parallel' (animations, config)
    let inline stagger ms animations = Animated.stagger animations ms

    let inline add a b = Animated.add a b
    let inline sub a b = Animated.subtract a b
    let inline multiply a b = Animated.multiply a b
    let inline divide a b = Animated.divide a b
    let inline modulo a b = Animated.modulo a b
    let inline diffClamp min max animation = Animated.diffClamp animation min max

    let inline event listener = Animated.event listener
    let inline eventCF listener config = Animated.event (listener, config)
    let inline loop animation = Animated.loop animation
    let inline loopCF config animation = Animated.loop (animation, config)

    let inline forkEvent listener event = Animated.forkEvent event listener
    let inline unforkEvent listener event = Animated.unforkEvent event listener

    /// Same as ``animation.x``.
    /// Take only XY animations.
    let inline getX (animation: AnimValue) : float = animation?x
    /// Same as ``animation.y``.
    /// Take only XY animations.
    let inline getY (animation: AnimValue) : float = animation?y

    /// Same as ``animation.start()``.
    let inline start (animation: AnimFunc) = animation.start()
    /// Same as ``startAnimation``, but with a callback.
    let inline startCB callback (animation: AnimFunc) = animation.start callback
    /// Same as ``animation.stop()``.
    let inline stop (animation: AnimFunc) = animation.stop()
    /// Same as ``animation.reset()``.
    let inline reset (animation: AnimFunc) = animation.reset()
    /// Same as ``animation.setValue(newValue)``.
    let inline setValue (newValue: float) (animation: AnimValue) : unit = animation?setValue newValue
    /// Same as ``animation.setOffset(offset)``.
    let inline setOffset (offset: float) (animation: AnimValue) : unit = animation?setOffset offset
    /// Same as ``animation.flattenOffset()``.
    let inline flattenOffset (animation: AnimValue) : unit = animation?flattenOffset()
    /// Same as ``animation.extractOffset()``.
    let inline extractOffset (animation: AnimValue) : unit = animation?extractOffset()
    /// Same as ``animation.addListener(callback)``.
    let inline addListener (callback: {| value: AnimValue |} -> unit) (animation: AnimValue) : string = animation?addListener callback
    /// Same as ``animation.removeListener(id)``.
    let inline removeListener (id: string) (animation: AnimValue) : unit = animation?removeListener id
    /// Same as ``animation.removeAllListeners()``.
    let inline removeAllListeners (animation: AnimValue) : unit = animation?removeAllListeners()
    /// Same as ``animation.stopAnimation()``.
    let inline stopAnimation (animation: AnimValue) : unit = animation?stopAnimation()
    /// Same as ``animation.stopAnimation(callback)``.
    let inline stopAnimationCB (callback: {| value: AnimValue |} -> unit) (animation: AnimValue) : unit = animation?stopAnimation callback
    /// Same as ``animation.resetAnimation()``.
    let inline resetAnimation (animation: AnimValue) : unit = animation?resetAnimation()
    /// Same as ``animation.resetAnimation(callback)``.
    let inline resetAnimationCB (callback: {| value: AnimValue |} -> unit) (animation: AnimValue) : unit = animation?resetAnimation callback
    /// Same as ``animation.interpolate(config)``.
    let inline interpolate (config: seq<IInterpolateProp>) (animation: AnimValue) : AnimValue = animation?interpolate (createObj !!config)
    /// Same as ``animation.getLayout()``.
    let inline getLayout (animation: AnimValue) : {| left: float; top: float |} = animation?getLayout()
    /// Same as ``animation.getTranslateTransform()``.
    let inline getTranslateTransform (animation: AnimValue) : ITransform = animation?getTranslateTransform()


[<Erase>]
module Comp =
    [<Erase; RequireQualifiedAccess>]
    type Animated =
        static member inline view = Interop.createElementFromName "Animated.View"
        static member inline image = Interop.createElementFromName "Animated.Image"
        static member inline text = Interop.createElementFromName "Animated.Text"
        static member inline scrollView = Interop.createElementFromName "Animated.ScrollView"
        static member inline flatList = Interop.createElementFromName "Animated.FlatList"
        static member inline sectionList = Interop.createElementFromName "Animated.SectionList"