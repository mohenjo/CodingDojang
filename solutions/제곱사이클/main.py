def sqr_seq(arg: int):
    src = [arg] # 제곱사이클 수열
    hasfound = False # 제곱사이클 종료 조건
    while len(src) < 100:
        chkval = src[-1]
        nextval = sum(int(s) ** 2 for s in str(chkval))
        if nextval in src:
            hasfound = True # 순환을 찾은 경우
            break
        src.append(nextval)
    return hasfound, src


if __name__ == '__main__':
    arg = 12
    rst = sqr_seq(arg)
    expr = str(len(rst[1])) if rst[0] == True else "100개 이상"
    print(expr)
