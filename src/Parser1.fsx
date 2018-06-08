#load "ValueHolder.fsx"
open ValueHolder

open System.IO

let viaStreamReader(file: string) =
    use reader = File.OpenText file
    while reader.EndOfStream |> not do
        ValueHolder.FromLine (reader.ReadLine()) |> ignore

#time
viaStreamReader "release/example-input.txt"
#time