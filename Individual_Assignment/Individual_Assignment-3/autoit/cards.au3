 #include <AutoItConstants.au3>
 $x=500
 $y=0
 MouseClick($MOUSE_CLICK_LEFT, 150, 15, 1)  ;
 sleep($x)
 send("{APPSKEY}");
 sleep($x)
 send("{UP 14}")
 sleep(200);
 send("{RIGHT}")
 sleep(200);
 send("{ENTER}")
 sleep($x)
 send("{RIGHT}")
 sleep($x)
 send("{ALTDOWN}")
 sleep($x)
 send("F")
 send("{ALTUP}")

 sleep($x)
 send("{DOWN 3}")
 sleep($x)
 send("{ENTER}")
 sleep($x)
 send("{TAB}")
 sleep($x)
 send("j")
 sleep($x)
 send("{ENTER}")
  sleep($x)
 send("{ENTER}")
 sleep($x)
 send("{ALTDOWN}")
 sleep($x)
 send("{F4}")
 send("{ALTUP}")
  sleep($x)
 send("{RIGHT}")
