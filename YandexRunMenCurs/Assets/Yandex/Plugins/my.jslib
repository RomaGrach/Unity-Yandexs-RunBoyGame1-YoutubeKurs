mergeInto(LibraryManager.library, {

  Hello: function () {
    window.alert("Hello, world!");
    console.log("Hello, world!");
  },

  GiveMePlayerData: function () {
    console.log(player.getName());
    myGameInstance.SendMessage('Yandex', 'SetName', player.getName());
    myGameInstance.SendMessage('Yandex', 'SetPhoto', player.getPhoto("medium"));
  },
  
	SaveExtern: function(date) {
    	var dateString = UTF8ToString(date);
    	var myobj = JSON.parse(dateString);
    	player.setData(myobj);
  	},

  	LoadExtern: function(){
    	player.getData().then(_date => {
        	const myJSON = JSON.stringify(_date);
        	myGameInstance.SendMessage('Progress', 'SetPlayerInfo', myJSON);
    	});
 	},



});
