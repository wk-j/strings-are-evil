## Strings Are Evil

- [Strings Are Evil](https://medium.com/@indy_singh/strings-are-evil-a803d05e5ce3)

```bash
fsharpc src/Parser01.fsx --out:release/v1.exe
fsharpc src/Parser02.fsx --out:release/v2.exe
fsharpc src/Parser03.fsx --out:release/v3.exe
fsharpc src/Parser04.fsx --out:release/v4.exe
fsharpc src/Parser05.fsx --out:release/v5.exe
fsharpc src/Parser06.fsx --out:release/v6.exe
fsharpc src/Parser07.fsx --out:release/v7.exe

wk-profiler release/v1.exe | grep -m 10 System
wk-profiler release/v2.exe | grep -m 10 System
wk-profiler release/v3.exe | grep -m 10 System
wk-profiler release/v4.exe | grep -m 10 System
wk-profiler release/v5.exe | grep -m 10 System
wk-profiler release/v6.exe | grep -m 10 System
wk-profiler release/v7.exe | grep -m 10 System
```