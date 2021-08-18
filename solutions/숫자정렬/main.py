import itertools


def sort_list(alist: list):
    evens = [i for i in alist if i % 2 == 0]
    evens.sort(reverse=True)
    odds = [i for i in alist if i % 2 == 1]
    odds.sort(reverse=False)

    if len(evens) != len(odds):
        raise ValueError("짝수와 홀수의 개수가 같지 않습니다.")

    return list(itertools.chain(*zip(odds, evens)))


if __name__ == '__main__':
    args = [4, 1, 3, 2, 6, 5]
    print(sort_list(args))
