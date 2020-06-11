using Protobuf;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestProtoSerAnUnSer : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        //1.序列化
        StoreRequest storeRequest = new StoreRequest();
        storeRequest.Name = "goods";
        storeRequest.Num = -50;
        storeRequest.Result = -1;
        for (int i = 0; i < 50; i++)
        {
            string str = $"str{i + 1}";
            storeRequest.MyList.Add(str);
        }
        byte[] bytes=ProtobufTool.Serialize(storeRequest);
        //2.反序列化
        StoreRequest storeRequestUnSer = ProtobufTool.Deserialize<StoreRequest>(bytes);
        byte[] maBytes = DeSerialize.Serialize(storeRequest);
        //2.反序列化
        StoreRequest maStoreRequestUnSer = DeSerialize.Serialization<StoreRequest>(maBytes);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
