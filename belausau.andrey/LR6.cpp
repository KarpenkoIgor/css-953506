#include <stdio.h>
#include <stdlib.h>
#include <string.h>

//вапвдопваопва
typedef struct item {
    char *data;
    struct item *left;
    struct item *right;
} Item;

void AddNode(char *data, Item **node)
{
    if (*node == NULL) {
        *node = (Item*)calloc(1, sizeof(Item));
        (*node)->data = data;
        (*node)->left = (*node)->right = NULL;
    }
    else {
        if (strcmp(data, (*node)->data) <= 0)
            AddNode(data, &(*node)->left);
        else AddNode(data, &(*node)->right);
    }
}

void LeftOrder(Item *node)
{
    if (node->left)
        LeftOrder(node->left);
    printf("%s ", node->data);
    if (node->right)
        LeftOrder(node->right);
}

void RightOrder(Item *node)
{
    if (node->right)
        RightOrder(node->right);
    printf("%s ", node->data);
    if (node->left)
        RightOrder(node->left);
}

int main(){
    int j = 0;
    char symb;
    char *word = (char*)calloc(20, sizeof(char*));
    bool isInputEmpty = true;
    Item *root = NULL;

    printf_s("Input : ");

    while (symb = getchar()) {
        if (symb == ' ' || symb == '\n') {
            word[j] = '\0';
            if (j > 0) {
                printf_s("%s\n", word);
                AddNode(word, &root);
                isInputEmpty = false;
                word = (char*)calloc(20, sizeof(char*));
            }
            j = 0;
            if (symb == '\n') break;
        }
        else {
            word[j++] = symb;
        }
    }

    if (isInputEmpty == false) {
        printf_s("Left order : ");
        LeftOrder(root);
        printf_s("\nRight order : ");
        RightOrder(root);
    }
    else printf_s("Empty input");

    free(word);

    return 0;
}