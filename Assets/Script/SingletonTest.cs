using Unity.VisualScripting;
using UnityEngine;

public class SingletonTest : MonoBehaviour
{
    // 디자인 패턴 중 하나. 자주 쓰임
    // 인스턴스가 하나만 존재함(유일성 보장)
    // 전역 접근점 제공(정적 Instance 프로퍼티 등)
    // 인스턴스 생성 통제(생성자 비공개 또는 팩토리)
    // 지연 초기화 가능(필요 시 생성)
    // 스레드 안전 고려 필요(멀티스레드 환경에서 동기화)
    // 생명주기 관리 필요(언제 생성·파괴할지 명확히)
    // 상태 공유로 인한 사이드 이펙트 위험(전역 상태 증가)
    // 단위 테스트와 의존성 주입이 어려움(테스트용 대체가 불편)
    // Unity 특이사항: MonoBehaviour는 new 불가 → Awake/OnEnable에서 인스턴스 설정, 기존 인스턴스 체크, DontDestroyOnLoad 사용 고려
    // 남용 금지: 의존성 주입이나 명확한 소유권으로 대체 가능한지 검토
    public static SingletonTest instance; // 자기 자신을 객체로 생성

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void PlayerSound()
    {
        Debug.Log("플레이어 사운드야");
    }

    public void EnemySound()
    {
        Debug.Log("적 사운드야");
    }
}
