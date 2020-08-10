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

### Copyright disclaimer
Even though this program as a whole was developed my me and an exact copy of it won't be found anywhere else on the internet apart from this repository, the most important part of its code (the one that is responsible for calculating the hash sum) was not originally written by me. This program was one of my first programming attempts so I followed a video tutorial on how to implement the hash sum calculator function. Back then I didn't even understand the MD5 algorithm. For that reason, I reckon that it is unfair to say that I own the code, so anyone who shows interest in this project is free to clone it and modify it and/or copy parts of its code on their own account.

### Special thanks
Spacial thanks to Dan Wager from the "Better Coder" YouTube channel for publishing their tutorial on the C#.NET implementation of the MD5 hash sum calculating function. ([video](https://www.youtube.com/watch?v=9MJAUL7G49w)).
