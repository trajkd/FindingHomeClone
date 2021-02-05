# Finding Home Clone // Whatsapp UI in Unity with Fungus integration

![A screenshot of the chat app](https://i.imgur.com/QKPApXG.png)

This is a simple Whatsapp UI made in Unity inspired from the [UNHCR Finding Home game](https://play.google.com/store/apps/details?id=org.unhcr.findinghome&hl=en_IE). It uses Fungus to manage the flow of messages and the player's choices. It can be used to build your own Choose Your Own Adventure game.
## Structure
The Home screen makes it possible to choose the language and to open the gallery and the chat app. From the chat app, the player goes to the chats list and then enters a specific chat. In this simple example the chat with Ishak is the only chat that's available. Once inside the actual conversation the messages will appear one after another with a pause of 2 seconds between them (the pause can be skipped with a click on the screen). As an example, there is a small conversation made with a Fungus flowchart already loaded. When the player needs to make a choice, the select button is activated and the player can make his choice. The player avatar can be clicked to go to the achievements screen. Each character avatar can be also clicked to go to its current affinity status (i.e. relationship status with the player which can be modified throughout the conversation).

## Files
- **Option1Selected.cs**: This script manages the painting of the messages on the screen and the player's choices. It contains these methods that can be invoked with the Scripting/Invoke Method command in Fungus:
	- PaintFirstReply(string  replyString, Sprite  avatar): Paints on screen the very first text reply by the player. It appears immediately.
	- PaintReply(string  replyString, Sprite  avatar): Waits for 2 seconds or a click input and then paints on screen a text reply by the player.
	- PaintReplyVoiceover(string  replyString, Sprite  avatar): Waits for 2 seconds or a click input and then paints on screen a text reply by the player as a voiceover (the message will appear with some transparency and the text will be in italics).
	- PaintFirstResponse(string  responseString, Sprite  avatar): Paints on screen the very first text response by a character. It appears immediately.
	- PaintResponse(string  responseString, Sprite  avatar): Waits for 2 seconds or a click input and then paints on screen a text response by a character.
	- PaintResponseWithImage(Sprite  image, Sprite  avatar): Waits for 2 seconds or a click input and then paints on screen an image response by a character.
	- PaintResponseWithAffinity(Sprite  avatar, bool  isPositve): Waits for 2 seconds or a click input and then paints on screen an update on the affinity with a character. If isPositive is set to true, a beating heart will appear next to the avatar of the character. If isPositive is set to false, a greyed out heart will appear next to the avatar of the character.
	- SetAffinity(string  name, int  diff): Has to be used alongside PaintResponseWithAffinity to update the internal variables for a character's affinity. diff can be set to a negative or positive integer (e.g. 2 to add two hearts; -1 to remove one heart)
	- PaintFirstNarrator(string  narratorString): Paints on screen the very first text message from the narrator (a message that is not sent by any of the characters or the player). It appears immediately.
	- PaintNarrator(string  narratorString): Waits for 2 seconds or a click input and then paints on screen a text message from the narrator.
	- PaintNarratorWithImage(Sprite  image): Waits for 2 seconds or a click input and then paints on screen an image message from the narrator.
	- ChangeReply(string  optionA, string  optionB): Sets two choices from which the player can choose to continue the conversation
	- ChangeReplyWithOneOption(string  optionA): Sets a single choice that the player has to choose to continue the conversation
	- ChangeReplyWithThreeOptions(string  optionA, string  optionB, string  optionC): Sets two choices from which the player can choose to continue the conversation
	- ActivateSelection(): Enables to select the player's choices by unlocking the reply section that will slide down from the bottom when clicking on the Select button
	- UnlockAnImage(Sprite  image): Unlocks an image in the Gallery app
	- UnlockAnAchievement(Sprite  image): Unlocks an achievement in the player's profile (accessible by clicking on the player's avatar)
- **AffinityPainter.cs**: This script paints the information on the characters' profiles (accessible by clicking on each character's avatar)
- **ImageClick.cs**, **ImageClickFromGallery.cs**, **ImageZoom.cs**: These scripts manage the zoom and pan on an image. The functionality is far from perfect and I'll try to fix it. Help is always welcome.
- **ItalianTranslator.cs**, **LanguageToggler.cs**, **SetLanguage.cs**, **TextLocalizer.cs**: Scripts for translation of text messages and UI elements.
- **ShowUnlockedImages.cs**, **UnlockImage.cs**: Scripts for unlocking images and viewing unlocked images in the gallery app.
- **ShowAchievements.cs**: Script for viewing achievements
- Other scripts are for animations and transitions from one scene to another.
## Usage

Add inside the script **Option1Selected.cs** entries to the `avatarColors` dictionary for each character with the name of the avatar's sprite you're using for the character as key and the color you want to give to its name on screen as value. Also add entries to the dictionaries inside the `avatarNamesTranslations` dictionary with the name of the avatar's sprite you're using for the character as key and the name you want to give to the character in that specific language (by default, there are English and Italian). 

*Optional*: Modify and add code inside **Option1Selected.cs** to include a variable for affinity for each character (near line 25 - `public  static  int  userAffinity = 3;`) and add code to the SetAffinity method (near line 305) accordingly. Then, inside **AffinityPainter.cs** add code near line 13 to update the `avatarAffinities` dictionary with the name of the avatar's sprite you're using for the character as key and the variable of the character you just added in **Option1Selected.cs** as value.
Inside **ItalianTranslation.cs** you can add to the `italianTranslations` dictionary translations for text messages. This can be easily used for translations in other languages other than Italian.
Inside **ShowAchievements.cs** add to the dictionaries inside the `achievementsTitlesAndDescriptions` dictionary the name of each achievement's sprite as key and the achievement title and description as value.

Now make a flowchart in Fungus to add your messages and player's choices. Follow the example already loaded to understand how to structure your flowchart.

## Credits
Heart, music, gallery and browser icons made by <a href="https://www.freepik.com" title="Freepik">Freepik</a> from <a href="https://www.flaticon.com/" title="Flaticon">www.flaticon.com</a>

User icon made by <a href="https://www.flaticon.com/authors/vectors-market" title="Vectors Market">Vectors Market</a> from <a href="https://www.flaticon.com/" title="Flaticon">www.flaticon.com</a>

Chat icon made by <a href="https://www.flaticon.com/authors/smartline" title="Smartline">Smartline</a> from <a href="https://www.flaticon.com/" title="Flaticon">www.flaticon.com</a>

Post-it icon made by <a href="https://www.flaticon.com/authors/pixel-perfect" title="Pixel perfect">Pixel perfect</a> from <a href="https://www.flaticon.com/" title="Flaticon">www.flaticon.com</a>

Telephone icon made by <a href="https://www.flaticon.com/authors/prettycons" title="prettycons">prettycons</a> from <a href="https://www.flaticon.com/" title="Flaticon">www.flaticon.com</a>

Whatsapp background taken from [SetAsWall](https://www.setaswall.com/whatsapp-wallpapers/whatsapp-wallpaper-112/).
The picture in the Home screen is a generic picture of Klue from Ingress.

The achievement badge was taken from [this repository](https://github.com/cr0ybot/ingress-logos).
