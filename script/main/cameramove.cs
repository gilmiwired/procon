using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cameramove : MonoBehaviour
{
    private Vector3 touchStartPos;
    private Vector3 touchEndPos;
    private string Direction;
    private float baseDistance;
    private CharacterController controller;
    public int zoomrange_max = 1;
    public int zoomrange_min = 1;
    public int moverange = 1;
    private GameObject tile;
    public GameObject desert;
    public GameObject firepower;
    public GameObject windpower;
    private int as1=0;
    public float movespeed = 40.0f;
    public float zoomspeed = 10.0f;
    public int movedirection = 1;
    public int zoomdirection = 1;
    public int ablegame = 1;
    public int select = 0;

    public int forest_num=9;
    public int mine_num=3;
    public int grassland_num=5;
    public int windpower_num=0;
    public int firepower_num=0;
    public int wealth = 10;
    public int culture = 10;
    public int nature = 90;
    public int population = 3;
    public int house = 1;
    // Update is called once per frame
    void Update()
    {
        if (ablegame == 1)
        {
            if (Input.touchCount == 1)
            {
                Flick();
            }
            else if (Input.touchCount == 2)
            {
                Zoom();
            }
        }
        else {
            as1 = Judgetile(tile);
            if (as1!=0 && select==2) {
                Destroy(tile);
                Instantiate(desert, new Vector3(tile.transform.position.x, tile.transform.position.y, tile.transform.position.z), Quaternion.identity);
                as1 = 0;
                select = 0;
            }
            if (as1 != 0 && select == 28)
            {
                Destroy(tile);
                Instantiate(windpower, new Vector3(tile.transform.position.x, tile.transform.position.y, tile.transform.position.z), Quaternion.identity);
                switch (as1) {
                    case 1:
                        forest_num--;
                        break;
                    case 2:
                        mine_num--;
                        break;
                    case 3:
                        grassland_num--;
                        break;
                }
                windpower_num++;
                as1 = 0;
                select = 0;
            }
            if (as1 != 0 && select == 29)
            {
                Destroy(tile);
                Instantiate(firepower, new Vector3(tile.transform.position.x, tile.transform.position.y, tile.transform.position.z), Quaternion.identity);
                switch (as1)
                {
                    case 1:
                        forest_num--;
                        break;
                    case 2:
                        mine_num--;
                        break;
                    case 3:
                        grassland_num--;
                        break;
                }
                firepower_num++;
                as1 = 0;
                select = 0;
            }
        }
    }

    void Flick()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            touchStartPos = new Vector3(Input.mousePosition.x,
                                        Input.mousePosition.y,
                                        Input.mousePosition.z);
        }
        //if (Input.GetKeyUp(KeyCode.Mouse0))
        if(Input.GetKey(KeyCode.Mouse0))
        {
            touchEndPos = new Vector3(Input.mousePosition.x,
                                      Input.mousePosition.y,
                                      Input.mousePosition.z);
            GetDirection();
        }
        if (Input.GetKeyUp(KeyCode.Mouse0)) {
            float directionX = touchEndPos.x - touchStartPos.x;
            float directionY = touchEndPos.y - touchStartPos.y;
            if (Mathf.Abs(directionY)+Mathf.Abs(directionX) <= 10.0) {
                tile = getClickObject();
                if (Judgetile(tile) != 0) {
                    select = 1;
                }
                /*Debug.Log(tile);
                switch (tile.tag) {
                    case "forest":
                        sel.select = 1;
                        mb.AppearUI();
                        Debug.Log("1");
                        if (sel.select == 2) { 
                        Destroy(tile);
                        Instantiate(desert, new Vector3(tile.transform.position.x, tile.transform.position.y, tile.transform.position.z), Quaternion.identity);
                        }Debug.Log("5");
                        break;
                    case "mine":
                        Destroy(tile);
                        Instantiate(desert, new Vector3(tile.transform.position.x, tile.transform.position.y, tile.transform.position.z), Quaternion.identity);
                        break;
                    case "grassland":
                        Destroy(tile);
                        Instantiate(desert, new Vector3(tile.transform.position.x, tile.transform.position.y, tile.transform.position.z), Quaternion.identity);
                        break;
                    case "river":
                        Destroy(tile);
                        Instantiate(desert, new Vector3(tile.transform.position.x, tile.transform.position.y, tile.transform.position.z), Quaternion.identity);
                        break;
                    case "riverf":
                        break;
                }
                Debug.Log("6");*/
            }
        }
    }
    void GetDirection()
    {
        float directionX = touchEndPos.x - touchStartPos.x;
        float directionY = touchEndPos.y - touchStartPos.y;
        if (directionX < 5.0f && directionX > -5.0f && directionY < 5.0f && directionY > -5.0f) {
            return;
        }
        if (directionX == 0.0f)
        {
            if (directionY < 0.0f)
            {
                Direction = "down";
            }
            else if (directionY > 0.0f)
            {
                Direction = "up";
            }
            else
            {
                Direction = "touch";
            }
        }
        else if (directionY / directionX > 0.0f)
        {
            if (directionY > 0.0f)
            {
                if (directionY / directionX > 3.0f)
                {
                    Direction = "up";
                }
                else if (directionY / directionX > 0.5f)
                {
                    Direction = "rup";
                }
                else
                {
                    Direction = "right";
                }
            }
            else if (directionY < 0.0f)
            {
                if (directionY / directionX > 3.0f)
                {
                    Direction = "down";
                }
                else if (directionY / directionX > 0.5f)
                {
                    Direction = "ldown";
                }
                else
                {
                    Direction = "left";
                }
            }
        }
        else if (directionY / directionX < 0.0f)
        {
            if (directionY > 0)
            {
                if (directionY / directionX < -3.0f)
                {
                    Direction = "up";
                }
                else if (directionY / directionX < -0.5f)
                {
                    Direction = "lup";
                }
                else
                {
                    Direction = "left";
                }
            }
            else if (directionY < 0.0f)
            {
                if (directionY / directionX < -3.0f)
                {
                    Direction = "down";
                }
                else if (directionY / directionX < -0.5f)
                {
                    Direction = "rdown";
                }
                else
                {
                    Direction = "right";
                }
            }
        }
        else {
            if (directionX > 0.0f)
            {
                Direction = "right";
            }
            else if (directionX < 0.0f)
            {
                Direction = "left";
            }
            else {
                Direction = "touch";
            }
        }
        if (Flickrange(Direction))
        {
            switch (Direction)
            {
                case "up":
                    //上フリックされた時の処理
                    transform.position += new Vector3(0, 0, -1*movedirection) * Time.deltaTime * movespeed;
                    break;

                case "down":
                    //下フリックされた時の処理
                    transform.position += new Vector3(0, 0, 1*movedirection) * Time.deltaTime * movespeed;
                    break;

                case "right":
                    //右フリックされた時の処理
                    transform.position += new Vector3(-1*movedirection, 0, 0) * Time.deltaTime * movespeed;
                    break;

                case "left":
                    //左フリックされた時の処理
                    transform.position += new Vector3(1*movedirection, 0, 0) * Time.deltaTime * movespeed;
                    break;

                case "rup":
                    transform.position += new Vector3(-1*movedirection, 0, -1*movedirection) * Time.deltaTime * movespeed;
                    break;

                case "rdown":
                    transform.position += new Vector3(-1*movedirection, 0, 1*movedirection) * Time.deltaTime * movespeed;
                    break; 

                case "ldown":
                    transform.position += new Vector3(1*movedirection, 0, 1*movedirection) * Time.deltaTime * movespeed;
                    break;

                case "lup":
                    transform.position += new Vector3(1*movedirection, 0, -1*movedirection) * Time.deltaTime * movespeed;
                    break;

                case "touch":
                    //タッチされた時の処
                    break;
            }
        }
    }

    void Zoom() {
        if (Input.touches[0].phase == TouchPhase.Began || Input.touches[1].phase == TouchPhase.Began)
        {
            baseDistance = Vector2.Distance(Input.touches[0].position, Input.touches[1].position);
        }
        float currentDistance = Vector2.Distance(Input.touches[0].position, Input.touches[1].position);
        float pinchDistance = (baseDistance - currentDistance);
        if (pinchDistance < 0 && Zoomrange(pinchDistance)) { transform.position += new Vector3(0, 1*zoomdirection, 0)* Time.deltaTime*(pinchDistance)*zoomspeed*0.05f;}
        else if (pinchDistance > 0 && Zoomrange(pinchDistance)) { transform.position += new Vector3(0, 1*zoomdirection, 0)* Time.deltaTime*(pinchDistance)*zoomspeed*0.05f;}
        }

    bool Zoomrange(float pinchDistance) {
        Vector3 pos = transform.position;
        pos += new Vector3(0, zoomdirection*1, 0) * Time.deltaTime * (pinchDistance) * zoomspeed*0.05f;
        if (pos.y > zoomrange_max)
        {
            return false;
        }
        else if (pos.y < zoomrange_min)
        {
            return false;
        }
        else if (pos.y <= zoomrange_max && pos.y >= zoomrange_min)
        {
            return true;
        }
        return false;
    }

    bool Flickrange(string Direction) {
        Vector3 pos = transform.position;

        switch (Direction)
        {
            case "up":
                //上フリックされた時の処理
                pos += new Vector3(0, 0, -1*movedirection) * Time.deltaTime * movespeed;
                if (pos.z > -1*moverange && pos.z < moverange)
                {
                    return true;
                }
                break;

            case "down":
                //下フリックされた時の処理
                pos += new Vector3(0, 0, 1*movedirection) * Time.deltaTime * movespeed;
                if (pos.z < moverange && pos.z> -1*moverange)
                {
                    return true;
                }
                break;

            case "right":
                //右フリックされた時の処理
                pos += new Vector3(-1*movedirection, 0, 0) * Time.deltaTime * movespeed;
                if (pos.x > -1*moverange && pos.x<moverange)
                {
                    return true;
                }
                break;

            case "left":
                //左フリックされた時の処理
                pos += new Vector3(1*movedirection, 0, 0) * Time.deltaTime * movespeed;
                if (pos.x < moverange && pos.x>-1*moverange)
                {
                    return true;
                }
                break;


            case "rup":
                pos += new Vector3(-1*movedirection, 0, -1*movedirection) * Time.deltaTime * movespeed;
                if (pos.x > -1*moverange && pos.x<1*moverange && pos.z > -1*moverange && pos.z<moverange)
                {
                    return true;
                }
                break;

            case "rdown":
                pos += new Vector3(-1*movedirection, 0, 1*movedirection) * Time.deltaTime * movespeed;
                if (pos.x > -1*moverange && pos.x<moverange && pos.z < moverange && pos.z>-1*moverange)
                {
                    return true;
                }
                break;

            case "ldown":
                pos += new Vector3(1*movedirection, 0, 1*movedirection) * Time.deltaTime * movespeed;
                if (pos.x < moverange && pos.x>-1*moverange && pos.z < moverange && pos.z>-1*moverange)
                {
                    return true;
                }
                break;

            case "lup":
                pos += new Vector3(1*movedirection, 0, -1*movedirection) * Time.deltaTime * movespeed;
                if (pos.x < moverange &&pos.x>-1*moverange&& pos.z > -1*moverange && pos.z<moverange)
                {
                    return true;
                }
                break;

            case "touch":
                //タッチされた時の処理
                return true;
        }
        return false;
    }

    public GameObject getClickObject()
    {
        GameObject result = null;
        // 左クリックされた場所のオブジェクトを取得
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();
            if (Physics.Raycast(ray, out hit))
            {
                result = hit.collider.gameObject;
            }
        return result;
    }

    private int Judgetile(GameObject tile) {
                switch (tile.tag)
                {
                    case "forest":
                return 1;
                    case "mine":
                return 2;
                    case "grassland":
                return 3;
                    case "river":
                return 0;
                    case "riverf":
                return 0;
            default:
                return 0;
                }
    }
}