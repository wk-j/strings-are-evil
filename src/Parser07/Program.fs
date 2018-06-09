open System

[<EntryPoint>]
let main argv =
    Parser.viaStreamReader "/Users/wk/Source/StringsAreEvil/release/example-input.txt"
    0 // return an integer exit code
