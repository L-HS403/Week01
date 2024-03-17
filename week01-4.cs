using System;
public class Week01_4
{
    enum PlayerState { Idle, Move, Attack }
    static void Main()
    {
        const int PlayerIdle = 0;
        const int PlayerMove = 1;
        const int PlayerAttack = 2;

        int playerState = PlayerAttack;

        switch (playerState)
        {
            case PlayerIdle:
                System.Console.WriteLine("플레이어 상태 : 대기");
                break;
            case PlayerMove:
                System.Console.WriteLine("플레이어 상태 : 이동");
                break;
            case PlayerAttack:
                System.Console.WriteLine("플레이어 상태 : 공격");
                break;
        }

        PlayerState playerState2 = PlayerState.Idle;

        switch (playerState2)
        {
            case PlayerState.Idle:
                System.Console.WriteLine("플레이어 상태 : 대기");
                break;
            case PlayerState.Move:
                System.Console.WriteLine("플레이어 상태 : 이동");
                break;
            case PlayerState.Attack:
                System.Console.WriteLine("플레이어 상태 : 공격");
                break;
        }
        int? intValue;
        intValue = null;
        System.Console.WriteLine(intValue.HasValue);

        intValue = 30;
        System.Console.WriteLine(intValue.HasValue);
        System.Console.WriteLine(intValue.Value);

        var valueInt = 33;
        var valueFloat = 33.4543f;
        var valueString = "문자열";

        System.Console.WriteLine("정수 : " + valueInt);
        System.Console.WriteLine("실수 : " + valueFloat);
        System.Console.WriteLine("문자열 : " + valueString);
    }
}
