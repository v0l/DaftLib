# DaftLib
 Daft.ie Search library

## Example

```chsarp
var d = new Daft();
var sb = new SearchBuilder()
	.WithAdState(new[] { AdState.Available })
	.WithKeyword("dublin");

var rslt = await d.Search(sb.Build());
if(rslt != null)
{
	//do something with rslt
}
```