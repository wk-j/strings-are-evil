#load "ValueHolder.fsx"
open ValueHolder

open System.IO

let viaStreamReader(file: string) =
    use reader = File.OpenText file
    while reader.EndOfStream |> not do
        let line = reader.ReadLine()
        if line.StartsWith "MNO" then
            ValueHolder.FromLine line |> ignore

#time
viaStreamReader "release/example-input.txt"
#time