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

    ShowAdv : function(){
        ysdk.adv.showFullscreenAdv({
    callbacks: {
        onClose: function(wasShown) {
            console.Log ("__----------- closed-----------");
          // some action after close
        },
        onError: function(error) {
          // some action on error
        }
    }
    })
    },


});
