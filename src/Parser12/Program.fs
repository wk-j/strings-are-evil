// Learn more about F# at http://fsharp.org

open System
open System.Text


let parseLine(line: StringBuilder) =
    if line.[0] = 'M' && line.[1] = 'N' && line.[2] = 'O' then
        ()


[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
