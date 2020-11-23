Zombie Alert Speed Fix
======================

It used to be that zombies on high alert would run across the landscape
like agitated banshees even if they were wounded. v102 fixed most
instances of this, but you could still witness this in some cases where
you caused the wounding while they were alerted (e.g. by shooting them
from outside their sight range).

This mod fixes that.

Zombies now remember that they are injured in any mode and will move at
a limping pace.

Requirements
------------

* Unity Mod Manager installed into Survivalist: Invisible Strain.

Build
-----

1. Checkout to `dev/ZombieAlertSpeedFix`.
2. From the `dev/ZombieAlertSpeedFix/src` directory, run `dotnet build`.
3. Copy `dev/ZombieAlertSpeedFix/src/bin/Debug/net40/ZombieAlertSpeedFix.dll` 
   and `dev/ZombieAlertSpeedFix/Info.json` to `Mods/ZombieAlertSpeedFix`.

License
-------

I claim nothing. ¯\\_(ツ)_/¯
