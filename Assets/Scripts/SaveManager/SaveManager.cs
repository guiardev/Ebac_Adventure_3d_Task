using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core.Singleton;

public class SaveManager : Singleton<SaveManager>{

    [SerializeField] private SaveSetup _saveSetup;

    // streamingAssetsPath salva dentro da pasta StreamingAssets que vai estar na pasta do projeto no Assets
    private string _path = Application.streamingAssetsPath + "/save.txt";

    public Action<SaveSetup> FileLoaded;

    public int lastLevel;

    public SaveSetup Setup{

        get{ return _saveSetup; } //pegando class e suas variáveis
    }

    protected override void Awake() {

        base.Awake();
        DontDestroyOnLoad(gameObject);

        // _saveSetup = new SaveSetup(); // uma nova instância SaveSetup
        // _saveSetup.lastLevel = 2;
        // _saveSetup.playerName = "guigamer";

    }

    private void CreateNewSave(){
        _saveSetup = new SaveSetup(); // uma nova instância SaveSetup
        _saveSetup.lastLevel = 0;
        _saveSetup.playerName = "guigamer";
    }

    private void Start() {
        Invoke(nameof(Load), .1f);
    }

    #region SAVE

    [NaughtyAttributes.Button]
    private void Save (){
        
        /*
        SaveSetup setup = new SaveSetup(); // uma nova instância SaveSetup
        setup.lastLevel = 2;
        setup.playerName = "guigamer";
        */

        // transformando método SaveSetup e json
        string setupToJson = JsonUtility.ToJson(_saveSetup, true);

        Debug.Log(setupToJson);

        SaveFile(setupToJson);
    }

    public void SaveItems(){

        //buscando valores das variáveis dos items
        _saveSetup.coins = Itens.ItemManager.Instance.GetItemByType(Itens.ItemType.COIN).soInt.value;
        _saveSetup.health = Itens.ItemManager.Instance.GetItemByType(Itens.ItemType.LIFE_PACK).soInt.value;
        Save();
    }

    public void SaveName(string text){
        _saveSetup.playerName = text;
        Save();
    }

    public void SaveLastLevel(int level){
        _saveSetup.lastLevel = level;
        SaveItems();
        Save();
    }

    #endregion

    private void SaveFile(string json){

        // dataPath sava o arquivo dentro do projeto
        // persistentDataPath sava o arquivo na pasta do usuário do sistema operacional
        // streamingAssetsPath salva dentro da pasta StreamingAssets que vai estar na pasta do projeto no Assets
        //string path = Application.streamingAssetsPath + "/save.txt";    

        // string fileLoaded = "";

        // if(File.Exists(_path)){
        //     fileLoaded = File.ReadAllText(_path);
        // }

        Debug.Log(_path);
        File.WriteAllText(_path, json);
    }

    [NaughtyAttributes.Button]
    private void Load(){

        string fileLoaded = "";

        if(File.Exists(_path)){

            fileLoaded = File.ReadAllText(_path); //carregando arquivo load em json para string

            Debug.Log("string fileLoaded = File.ReadAllText(_path) = " + fileLoaded);

            _saveSetup = JsonUtility.FromJson<SaveSetup>(fileLoaded); // convertendo para json o fileLoaded
            Debug.Log("_saveSetup " + _saveSetup);

            lastLevel = _saveSetup.lastLevel;
            Debug.Log("lastLevel " + lastLevel);
        }else{
           CreateNewSave();
           Save();  
        }

        if(FileLoaded == null){
            Debug.Log("FileLoaded " + FileLoaded);
        }else{
            FileLoaded.Invoke(_saveSetup);
        }

    }

    [NaughtyAttributes.Button]
    private void SaveLevelOne(){
        SaveLastLevel(1);
    }

    [NaughtyAttributes.Button]
    private void SaveLevelFive(){
        SaveLastLevel(5);
    }
}

[System.Serializable]
public class SaveSetup{

    public int lastLevel;
    public float coins, health;
    public string playerName;
}