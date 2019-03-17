# Background thread loading test
Test Background Thread Loading Demo with C# API<br />
<br />
For Godot v3.1, it was tested on Windows 10 as well as Ubuntu 18.4.02.<br />
No problem is found so far, working good. 
<br />
<br />

Godot version: 3.0.6<br />
Mono JIT compiler version: 5.12.0.301<br />
<br />
When BackgroundLoad.cs is applied, every image attached to the scene is black.<br />
<br />
When background_load.gd is called from C#, the following problem occurs.<br />
For Ubuntu 18.4.02,
```
 Thread 1 (Thread 0x7f095db5c2c0 (LWP 4150)):
 #0  0x00007f095ccc3bf9 in __GI___poll (fds=0x7ffeee249728, nfds=1, timeout=-1) at ../sysdep
 #1  0x00007f095b64f747 in ?? () from /usr/lib/x86_64-linux-gnu/libxcb.so.1
 #2  0x00007f095b65145a in xcb_wait_for_special_event () from /usr/lib/x86_64-linux-gnu/libx
 #3  0x00007f095604d5fb in ?? () from /usr/lib/x86_64-linux-gnu/libGLX_mesa.so.0
 #4  0x00007f095604d748 in ?? () from /usr/lib/x86_64-linux-gnu/libGLX_mesa.so.0
 #5  0x00007f095604e92e in ?? () from /usr/lib/x86_64-linux-gnu/libGLX_mesa.so.0
 #6  0x00007f095604f869 in ?? () from /usr/lib/x86_64-linux-gnu/libGLX_mesa.so.0
 #7  0x00007f0953d66a99 in ?? () from /usr/lib/x86_64-linux-gnu/dri/i965_dri.so
 #8  0x00007f0953d66db1 in ?? () from /usr/lib/x86_64-linux-gnu/dri/i965_dri.so
 #9  0x00007f0953d62229 in ?? () from /usr/lib/x86_64-linux-gnu/dri/i965_dri.so
 #10 0x00000000013c1291 in RasterizerCanvasGLES3::canvas_begin() ()
 #11 0x00007f09539948b7 in ?? () from /usr/lib/x86_64-linux-gnu/dri/i965_dri.so
 #12 0x0000000004367560 in ?? ()
 #13 0x0000000000000000 in ?? ()
 =================================================================
 Got a SIGSEGV while executing native code. This usually indicates
 a fatal error in the mono runtime or one of the native libraries
 used by your application.
 =================================================================
```

For Windows 10, <br />
```
Problem Event Name: APPCRASH
Exception code: c0000005
```
