#pragma warning disable 0414, 0219, 0162, 0429, 0649
// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

// Blox Name: shoot
// Blox Ident: _f9608b95ce4b4d73abcb442b43a73ebc
namespace BloxGenerated
{
    
    [BloxEngine.ExcludeFromBlox()]
    [UnityEngine.AddComponentMenu("")]
    public class _f9608b95ce4b4d73abcb442b43a73ebc : UnityEngine.MonoBehaviour
    {
        public BloxEngine.BloxContainer bloxContainer;
        private BloxEngine.Variables.plyVar_Prefab b_Grenade_f2c5;
        // Init
        public void Awake()
        {
            this.bloxContainer = this.GetComponent <BloxEngine.BloxContainer>();
            this.b_Grenade_f2c5 = ((BloxEngine.Variables.plyVar_Prefab)(this.bloxContainer.FindVariable("_f9608b95ce4b4d73abcb442b43a73ebc", "Grenade").ValueHandler));
        }
        // Event name: OnMouseDown
        public void OnMouseDown()
        {
            UnityEngine.Network.Instantiate(b_Grenade_f2c5.GetValue(), new UnityEngine.Vector3(0F, 1F, 0.5F), new UnityEngine.Quaternion(0F, 0F, 0F, 0F), 0);
            this.GetComponent <UnityEngine.Rigidbody>().AddForce(0F, 200F, 0F, UnityEngine.ForceMode.Impulse);
        }
    }
}