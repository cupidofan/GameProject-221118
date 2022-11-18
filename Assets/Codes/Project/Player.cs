using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.CollabMigration;
using UnityEngine;

namespace PlatformShoot 
{
    public class Player : MonoBehaviour
    {
        private Rigidbody2D mRig;
        private float mPlayerSpeed = 5f;
        private float jumpForce = 12f;

        private void Start()
        {
            mRig=GetComponent<Rigidbody2D>();
        }
        private void FixedUpdate()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                mRig.velocity = new Vector2(mRig.velocity.x, jumpForce);
            }
            mRig.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * mPlayerSpeed, mRig.velocity.y);
        }
    }
}