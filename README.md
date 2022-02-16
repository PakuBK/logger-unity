# logger-unity
Simple Unity Logger with Conditional Logs.

## How to use

Add the custom scripting symbol "ENABLE_LOGS" in **Edit > Project Settings > Player > Other Settings**.

### CODE
```
using Paku.Logger;

QLogger.("Debug Messsage", "From Me")

// Output
[From Me] Debug Message
```
