## Strings Are Evil

- [Strings Are Evil](https://medium.com/@indy_singh/strings-are-evil-a803d05e5ce3)

```bash
fsharpc src/Parser1.fsx --out:release/v1.exe
fsharpc src/Parser2.fsx --out:release/v2.exe
fsharpc src/Parser3.fsx --out:release/v3.exe
fsharpc src/Parser4.fsx --out:release/v4.exe
fsharpc src/Parser5.fsx --out:release/v5.exe
fsharpc src/Parser6.fsx --out:release/v6.exe
fsharpc src/Parser7.fsx --out:release/v7.exe

wk-profiler release/v1.exe | grep -m 10 System
wk-profiler release/v2.exe | grep -m 10 System
wk-profiler release/v3.exe | grep -m 10 System
wk-profiler release/v4.exe | grep -m 10 System
wk-profiler release/v5.exe | grep -m 10 System
wk-profiler release/v6.exe | grep -m 10 System
wk-profiler release/v7.exe | grep -m 10 System
```