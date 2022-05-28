module Lit.TodoMVC.MyComponent

open Lit
open Fable.Core
open Fable.Core.JsInterop

let register() = ()

[<Emit("import tailwindStyles from '/src/out/style.css'")>]
let importTailwindStyles() = jsNative

importTailwindStyles()

[<Emit("tailwindStyles")>]
let tailwindStyles: string = jsNative

[<Emit("new CSSStyleSheet()")>]
let newCSSStyleSheet() = jsNative

[<LitElement("my-component")>]
let MyComponent() =
    let _ = LitElement.init(fun init ->
        init.useShadowDom <- true
    )

    let style = newCSSStyleSheet()
    style?replace(tailwindStyles)
    jsThis?shadowRoot?adoptedStyleSheets <- [| style |]

    html $"""
        <div class="bg-indigo-600 rounded border-2 border-teal-500 mb-2">
            My Component
        </div>
    """