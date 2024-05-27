# MD5Checker.NET
*A simple MD5 hash file integrity verification tool written in C#.NET.*

### Where is it needed
When one downloads a big file (i.e. an operating system installation disk image or a large dataset) without using an improved download manager or the BitTorrent protocol, there is a possibility that the download file ends up being corrupted due to package loss. Thankfully, there is a way to verify the integrity of the said file. One can calculate its MD5 hash sum and compare it to the hash sum mentioned in the website for the exact file they downloaded (if provided). That way, they can ensure that their file is not corrupted and safe to work with.

### Tools used:
- Visual Studio 2019 Community Edition
- Visual Studio 2010 Express

## Requirements:
- Windows 7 operating system or later.
- A modern version of the .NET Framework Runtime (recommended: v4.8)

### Special thanks
Spacial thanks to Dan Wager from the "Better Coder" YouTube channel for publishing their tutorial on the C#.NET implementation of the MD5 hash sum calculating function. ([video](https://www.youtube.com/watch?v=9MJAUL7G49w)).
