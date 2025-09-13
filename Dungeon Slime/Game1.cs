using DungeonSlime.Scenes;
using Microsoft.Xna.Framework.Media;
using MonoGameLibrary;


namespace Dungeon_Slime;

public class Game1 : Core
{
    private Song _theme;

    public Game1() : base("Dungeon Slime", 1280, 720, false)
    {

    }

    protected override void Initialize()
    {
        base.Initialize();

        Audio.PlaySong(_theme);
        ChangeScene(new TitleScene());


    }


    protected override void LoadContent()
    {
        _theme = Content.Load<Song>("audio/theme");
    }
}