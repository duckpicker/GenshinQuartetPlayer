# GenshinQuartetPlayer
## Presentation
<img src="icon.ico" align="left" width="60">

**GenshinQuartetPlayer** is a free application that allows you to easily play all the instruments featured in the Genshin Impact.
Whether it's a solo performance or a joint performance with friends in co-op.


## Usage

- [Downdland the .NET 7.0](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
- [Downland the latest version](github.com/duckpicker/GenshinQuartetPlayer/releases/latest) and put it in anywhere idk.
- Open the program with administrator rights and click `File` → `Open folder`.
    - if the folder was not created automatically, manually create the `GenshinQartetPlayer` folder in the documents library.
- Put your MIDI files (`.mid`) in this folder.
- Click the `Refresh` button next to the `Playlist`.
- Select the `song_name.mid` in `Playlist`.
- Click `Start Play` to play your song.

<div align="center"><img src=https://i.imgur.com/HXu2CiA.png></div>

 ## Features

 - You can change the transposition.
- You can enable/disable tracks in the MIDI file.
- You can choose an instrument. Supported instruments:
  - `Lyre/Zither`
  - `Old Lyre`
  - `Drum` (Only works with notes from the GM Drum Map)
    - Acoustic Bass Drum / 35
    - Bass Drum / 36
    - Acoustic Snare / 38
    - Electric Snare / 40
- You can select an `Input Device` and play on an external MIDI keyboard.
- You can create a server for cooperative play.

  ****Video demonstrating cooperative gameplay:****

  [![IMAGE ALT TEXT HERE](https://img.youtube.com/vi/YK8MU-7Ddkg/0.jpg)](https://www.youtube.com/watch?v=YK8MU-7Ddkg)

## Multiplayer

The distinctive feature of **GenshinQuartetPlayer** is the ability to play with your friends in **CO-OP** mode.

- To create a lobby, select `Multiplayer` → `Create lobby`.
- In the opened window, enter your name (automatically filled with the computer name) and your ping in Genshin Impact.
- After creation, the server will be launched on the default port 8080, and you can change the port in the settings in the main menu.
> The server operates on web sockets if someone needs that.

<div align="center"><img src=https://i.imgur.com/IfD6b1E.png></div>

**Here is what the user panel looks like:**
 <div align="center"><img src=https://i.imgur.com/AZpVlrW.png></div>


- In the admin panel, you can select a MIDI file, and it will be automatically sent to all connected users.

- Double-clicking on a user opens a window where you can adjust the user's offset.

- When you press the `Send offset` button, everyone except the admin will play a single note.
  - This function can be used to set delays for synchronized gameplay.
  - To adjust the user's offset, clients need to make the "Ready" button turn green.
  - During testing, we noticed that for connected users, you need to specify a negative ping value for Genshin Impact and subtract an additional 10-20 milliseconds due to the delay from the host to the clients. However, your setup may be different, so I recommend taking the time to fine-tune it with your friends.

- To check the delays for both the admin and the users, the admin should press the `Test` button.
- Once all users have configured their tracks, instruments, and transpositions and turned the `Ready` button green, the lobby admin can press the `Start Play` button.
  - The `Ready` / `Not Ready` button reflects the current status.
