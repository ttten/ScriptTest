using UnityEngine;
using System.Collections;

public class Boss {       
        private int hp    = 100; // 体力
        private int power = 25;  // 攻撃力
        private int mp    = 53;  // 魔法

        // 攻撃用の関数
        public void Attack() { 
                Debug.Log( this.power + "のダメージを与えた" );
        }

        // 防御用の関数
        public  void Defence(int damage) { 
                Debug.Log( damage+"のダメージを受けた" );
                // 残りhpを減らす
                this.hp -= damage;
        }

        // 魔法用の関数
        public void Magic(){
       		if (mp >= 5){
    	 		   	//残りmpを減らす
     			   	this.mp -= 5;
	     		   	Debug.Log("魔法攻撃をした。残りMPは" + mp);
        		} else {
        			Debug.Log("MPが足りないため魔法が使えない。");
        	}
   		}
}

public class Test : MonoBehaviour {

        void Start () {

		// 【課題(1)】----------------------------------------------------
        
        //int型の配列arrayを初期化
		int[] array = {100, -99, 82, 7, 33};

		//配列の各要素の値を順番に表示
		for(int i = 0; i < array.Length; i++){
			Debug.Log(array [i]);
		}

		//配列の各要素の値を逆順に表示
		for(int i = 4; i >= 0; i--){
			Debug.Log(array [i]);
		}


		// 【課題(2)】----------------------------------------------------

                // Bossクラスの変数を宣言してインスタンスを代入
                Boss lastboss = new Boss ();

                // Magic関数を11回実行
                for (int i = 0; i < 11; i++){
	                lastboss.Magic();
                }
        }
}