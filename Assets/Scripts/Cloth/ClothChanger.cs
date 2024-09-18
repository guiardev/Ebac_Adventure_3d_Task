using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cloth;

namespace Cloth{

    public class ClothChanger : MonoBehaviour{

        private Texture2D _defaultTexture;
        public SkinnedMeshRenderer mesh;
        public Texture2D texture;

        public string shaderIdName = "_EmissionMap"; // _EmissionMap da variável que voce poder achar em Inspector do player em Material em Select shader

        public void Awake() {
            _defaultTexture = (Texture2D) mesh.sharedMaterials[0].GetTexture(shaderIdName); // voltando com textura original
        }

        [NaughtyAttributes.Button]
        public void ChangeTexture(){
            mesh.sharedMaterials[0].SetTexture(shaderIdName, texture);
        }

        public void ChangeTexture(ClothSetup setup){
            mesh.sharedMaterials[0].SetTexture(shaderIdName, setup.texture);
        }

        public void ResetTexture(){
            mesh.sharedMaterials[0].SetTexture(shaderIdName, _defaultTexture);
        }
    }
}