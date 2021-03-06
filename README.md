# Aliens in Fashion
 
Group Members: Elaine Guan, Juan Camacho, Zainab Mohammad, Nick Magaru

"Aliens in Fashion" is a turn-based collecting computer game or board game for people ages 6 and up. In this game, players manage aliens and fashion items, dress up aliens, and host fashion shows. There are 4 planets with various fashion items and different types of aliens to be hired from.

There are three animated Mechanims: a rigged faceless alien that is the player, model aliens which are of the player's type or ones that wear a dress, and human enemies.

To follow other characters, humans and aliens both use Finite State Machines. In addition, humans use a flocking mechanism to populate and move through the graph and create a path towards the player.

Each map has different textures to symbolize different planet terrains. Unique textures on every map makes the gameplay challenging and actions that can be unlocked based on how many points are earned keep the user interested. Some maps have lights to light up darker corners. A distinct combination of medium sized paths along with narrow hallways and large areas on each map create an interesting and challenging map where the user must strategize their movements to get from vulnerable areas to safe areas. 

Others have particle systems, according to each theme. Other physics used include colliders used by an enemy character and Rigid Bodies on objects that are required to be solid, such as walls.

## Credits

Unity Assets:  
<a href="https://assetstore.unity.com/packages/2d/textures-materials/texture-glass-transparent-window-182052">Texture Glass Transparent Window by GlowFox Games</a>  
<a href="https://assetstore.unity.com/publishers/40099">Urban Night Sky by Kendall Weaver</a>  
<a href="https://assetstore.unity.com/packages/3d/characters/humanoids/sci-fi/free-animated-space-man-61548">Free Animated Space Man by HONETi</a>  
<a href="https://assetstore.unity.com/packages/vfx/particles/sherbb-s-particle-collection-170798">Sherbb's Particle Collection by Shrebb</a>  

Font:  
<a href="https://www.dafont.com/a-space.font">A Space by Studio Typo</a>  
<a href="https://fonts.google.com/specimen/Play#standard-styles">Play by Jonas Hecksher</a>  

Texture/Pattern Images:  
<a href="https://www.freepik.com/free-photo/3d-technology-geometric-black-background_13301681.htm#page=7&query=space+background&position=16">3d technology geometric black background by rawpixel.com</a>  
<a href="https://www.freepik.com/free-photo/stone-wall-texture-background-vintage-filter_1273893.htm#page=1&query=stone%20pattern&position=42">Stone wall texture or background - vintage filter by aopsan</a>  
<a href="https://www.freepik.com/free-photo/tropical-green-leaves-background_4102585.htm#page=1&query=green%20wall&position=40">Tropical green leaves background by rawpixel.com</a>  
<a href="https://www.freepik.com/free-photo/beautiful-old-rock-texture_13235534.htm#page=5&query=wall+texture&position=16">Beautiful old rock texture by wirestock</a>  
<a href="https://stock.adobe.com/images/red-lava-texture-background/183144766">Red lava texture background by thinnapat</a>  
<a href="https://www.pexels.com/photo/dirty-dry-pattern-texture-2004166/">Dirty dry pattern texture by Markus Spiske</a>  
<a href="https://www.pexels.com/photo/selective-focus-photography-of-green-plants-948099/">Selective focus photography of green plants by Irina Iriser</a>  
<a href="https://www.pexels.com/photo/cold-snow-pattern-texture-6609924/">Cold snow pattern texture by Karolina Grabowska</a>  
<a href="https://www.pexels.com/photo/red-and-orange-solar-flare-73873/">Red and orange solar flare by Pixabay</a>  
<a href="https://www.pexels.com/photo/black-and-white-carbon-pattern-2092075/">Black and white carbon pattern by Engin Akyurt</a>
<a href="https://assetstore.unity.com/packages/vfx/shaders/flexible-cel-shader-built-in-pipeline-112979/">Flexible Cel Shader by Zachary Peterson</a>

Sounds and Music:  
<a href="https://freesound.org/people/old_waveplay/sounds/399934/">Short Click/Snap Perc.wav by Waveplay</a>  
<a href="https://freesound.org/people/Kastenfrosch/sounds/162482/">Achievement.mp3 by Kastenfrosch</a>  
<a href="https://freesound.org/people/GabrielAraujo/sounds/242503/">Failure/wrong action.wav by GabrielAraujo</a>  
<a href="https://www.dl-sounds.com/royalty-free/space-loop/">Space Loop.wav by DL Sounds</a> 

Scripts:  
<a href="https://www.theappguruz.com/blog/ai-implementation-using-finite-state-machine-model">How to ace the FINITE State Machine Model in Unity AI Implementation by Rudra Gesota</a>  
<a href="https://gist.github.com/canyuva/8338f1cf679440f7950313e85718e006">Unity 5 Enemy Follow to Player C# Script by canyuva</a>  
<a href="http://wiki.unity3d.com/index.php?title=Flocking">Flocking by shinriyo & Benoit FOULETIER</a>  
<a href="https://www.youtube.com/watch?v=fnBPh35Bwwc">HOW TO CREATE PORTALS WITH UNITY AND C# - EASY TUTORIAL by Blackthornprod</a>  
<a href="https://www.youtube.com/watch?v=RsgiYqLID-U">MAIN MENU in Unity - Unity UI tutorial by Coco Code</a>  

## Assignment 8

UI Design:  
-Colors of buttons and text are too saturated and does not match the textures and other parts of the game (Modified by adding and using a new font to fit the game theme better and editing the colors of the buttons and text)  
-Text size of score and results of the actions may be too small (Modified by changing the sizes of the text and changing the position + spacing of the buttons)  
-There are no initial instructions on how to play the game, so the user may be confused on what the objectives and controls are  

Sound Design:  
See Sounds and Music credits and Design Document.  

## Assignment 9

Shader Design:  
-Toon shader applied to player to increase visibility  
-Lava shader applied to make floor more vibrant and to make it move  

Modifications in response to alpha feedback:  
-Player character turns faster  
-Camera and player repositioned so the player can see more of the environment  
-Settings and help screens added  
-Add new font to match game theme better, use TextMeshPro and add font material presets to have more flexibility in editing text  
-Menu and credits screens added  
-Win screen added  
