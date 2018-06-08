#load "ValueHolder.fsx"

open System.Text
open System
open ValueHolder
open System.IO

let sb = StringBuilder()
let parseSection (start, ends, line: string) =
    sb.Clear() |> ignore
    for i in start .. (ends - 1uy) do
        sb.Append(line.[int i]) |> ignore
    sb.ToString()

let findCommasInLine (line: string) =
    let bts: byte array = Array.zeroCreate 7
    let mutable counter = 0
    for i in 0 .. (line.Length - 1) do
        if line.[i] = ',' then
            bts.[counter] <-  byte i
            counter <- counter + 1
    bts

let viaStreamReader(file: string) =
    use reader = File.OpenText file
    while reader.EndOfStream |> not do
        let line = reader.ReadLine()
        if line.StartsWith "MNO" then
            let mm = findCommasInLine line
            ValueHolder.FromFields(
                parseSection (mm.[0] + 1uy, mm.[1], line) |> Int32.Parse,
                parseSection (mm.[1] + 1uy, mm.[2], line) |> Int32.Parse,
                parseSection (mm.[2] + 1uy, mm.[3], line) |> Int32.Parse,
                parseSection (mm.[3] + 1uy, mm.[4], line) |> Int32.Parse,
                parseSection (mm.[4] + 1uy, mm.[5], line) |> Double.Parse
            ) |> ignore


#time
viaStreamReader "release/example-input.txt"
#time