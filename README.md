Because of the current ChatGPT API models, the game needs to wait 1min to generate questions and answers. The systems works properly. After OpenAI update the models, the game will work properly.
However, if you want to implement OpenAI API to Unity, you can check this project to understand how you can use it.

Thanks to Sercan Altundas, we can use this OpenAI API which is not offical API of OpenAI.


To play this game, Users -> click a folder named your username -> Creating new Folder named .openai -> Open Notepad and save it inside folder as auth.json -> In the notepad do the following instructions below.

!!In the notepad : Take your api key and organization id from OpenAI website
{
    "api_key": "paste your api key here",
    "organization": "paste your organization id here"
}
