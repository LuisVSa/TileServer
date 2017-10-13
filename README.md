# TileServer

The Interface for SBuilderX Tiles Plugins

SBuilderX is a Visual Basic Windows programme to create sceneries for Microsoft Flight Simulator. Starting with version 3.10, SBuilderX is prepared to use a background image created from tiles downloaded from the Internet. This background image can then assist the scenery designer in creating roads, rivers, lakes, cities, etc, and in placing scenery objects. In this way, scenery items created by SBuilderX can be precisely positioned in the Flight Simulator world.

There will be a full repository of the SBuilderX but I pretend to publish repos of the tiles/graphics parts of SBuilderX as they may be used in complete different applications. These repos were created and publish here using Visual Studio 2017 (Community Edition). They  are:

TileServer (this one)

VirtualEarth (Plugin to download image tiles from Virtual Eart Servers)

TileDownload (an application that illustrates the use of the interface and of the plugins)

So, what is this interface and what it is needed for? This interface just creates the file TileServer.dll which is needed to compile Plugins and by the executable main command (TileDownload.exe in this illustration series). For more information, please see this article in my forum:

http://www.ptsim.com/forum/viewtopic.php?f=22&t=1053
