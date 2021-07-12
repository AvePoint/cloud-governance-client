/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    TreeNodeExtension,
    TreeNodeExtensionFromJSON,
    TreeNodeExtensionFromJSONTyped,
    TreeNodeExtensionToJSON,
    TreeNodeType,
    TreeNodeTypeFromJSON,
    TreeNodeTypeFromJSONTyped,
    TreeNodeTypeToJSON,
} from './';

/**
 * 
 * @export
 * @interface TreeNode
 */
export interface TreeNode {
    /**
     * 
     * @type {string}
     * @memberof TreeNode
     */
    webApplicationId?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TreeNode
     */
    webApplicationUri?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TreeNode
     */
    siteCollectionId?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TreeNode
     */
    siteCollectionUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TreeNode
     */
    siteId?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TreeNode
     */
    nodeId?: string | null;
    /**
     * 
     * @type {number}
     * @memberof TreeNode
     */
    startIndex?: number;
    /**
     * 
     * @type {number}
     * @memberof TreeNode
     */
    pageSize?: number;
    /**
     * 
     * @type {number}
     * @memberof TreeNode
     */
    pageIndex?: number;
    /**
     * 
     * @type {number}
     * @memberof TreeNode
     */
    fullCount?: number;
    /**
     * 
     * @type {string}
     * @memberof TreeNode
     */
    name?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TreeNode
     */
    title?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TreeNode
     */
    description?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TreeNode
     */
    displayName?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TreeNode
     */
    managedPath?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TreeNode
     */
    agentID?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TreeNode
     */
    fullPath?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TreeNode
     */
    farmName?: string | null;
    /**
     * 
     * @type {boolean}
     * @memberof TreeNode
     */
    hasNextPage?: boolean;
    /**
     * 
     * @type {string}
     * @memberof TreeNode
     */
    farmID?: string;
    /**
     * 
     * @type {string}
     * @memberof TreeNode
     */
    parentID?: string;
    /**
     * 
     * @type {TreeNodeExtension}
     * @memberof TreeNode
     */
    extension?: TreeNodeExtension | null;
    /**
     * 
     * @type {TreeNode}
     * @memberof TreeNode
     */
    parent?: TreeNode | null;
    /**
     * 
     * @type {TreeNodeType}
     * @memberof TreeNode
     */
    type?: TreeNodeType;
    /**
     * 
     * @type {string}
     * @memberof TreeNode
     */
    spObjectID?: string;
    /**
     * 
     * @type {string}
     * @memberof TreeNode
     */
    networkId?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TreeNode
     */
    parentSPObjectID?: string;
    /**
     * 
     * @type {string}
     * @memberof TreeNode
     */
    id?: string;
    /**
     * 
     * @type {boolean}
     * @memberof TreeNode
     */
    loadManagedPath?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof TreeNode
     */
    loadChildrenFromDB?: boolean;
    /**
     * 
     * @type {number}
     * @memberof TreeNode
     */
    loadedPageCount?: number;
    /**
     * 
     * @type {Array<TreeNode>}
     * @memberof TreeNode
     */
    children?: Array<TreeNode> | null;
    /**
     * 
     * @type {Array<TreeNode>}
     * @memberof TreeNode
     */
    selectedChildren?: Array<TreeNode> | null;
    /**
     * 
     * @type {string}
     * @memberof TreeNode
     */
    filterUrls?: string | null;
    /**
     * 
     * @type {number}
     * @memberof TreeNode
     */
    filterType?: number;
    /**
     * 
     * @type {number}
     * @memberof TreeNode
     */
    checkNumber?: number;
    /**
     * 
     * @type {string}
     * @memberof TreeNode
     */
    selectedWebAppIdSubSiteProvServ?: string;
    /**
     * 
     * @type {string}
     * @memberof TreeNode
     */
    selectedSiteCollIdsSubSiteProvServ?: string | null;
    /**
     * 
     * @type {number}
     * @memberof TreeNode
     */
    childrenType?: number;
    /**
     * 
     * @type {string}
     * @memberof TreeNode
     */
    listId?: string;
    /**
     * 
     * @type {string}
     * @memberof TreeNode
     */
    serverRelativeUrl?: string | null;
    /**
     * 
     * @type {string}
     * @memberof TreeNode
     */
    userName?: string | null;
}

export function TreeNodeFromJSON(json: any): TreeNode {
    return TreeNodeFromJSONTyped(json, false);
}

export function TreeNodeFromJSONTyped(json: any, ignoreDiscriminator: boolean): TreeNode {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'webApplicationId': !exists(json, 'webApplicationId') ? undefined : json['webApplicationId'],
        'webApplicationUri': !exists(json, 'webApplicationUri') ? undefined : json['webApplicationUri'],
        'siteCollectionId': !exists(json, 'siteCollectionId') ? undefined : json['siteCollectionId'],
        'siteCollectionUrl': !exists(json, 'siteCollectionUrl') ? undefined : json['siteCollectionUrl'],
        'siteId': !exists(json, 'siteId') ? undefined : json['siteId'],
        'nodeId': !exists(json, 'nodeId') ? undefined : json['nodeId'],
        'startIndex': !exists(json, 'startIndex') ? undefined : json['startIndex'],
        'pageSize': !exists(json, 'pageSize') ? undefined : json['pageSize'],
        'pageIndex': !exists(json, 'pageIndex') ? undefined : json['pageIndex'],
        'fullCount': !exists(json, 'fullCount') ? undefined : json['fullCount'],
        'name': !exists(json, 'name') ? undefined : json['name'],
        'title': !exists(json, 'title') ? undefined : json['title'],
        'description': !exists(json, 'description') ? undefined : json['description'],
        'displayName': !exists(json, 'displayName') ? undefined : json['displayName'],
        'managedPath': !exists(json, 'managedPath') ? undefined : json['managedPath'],
        'agentID': !exists(json, 'agentID') ? undefined : json['agentID'],
        'fullPath': !exists(json, 'fullPath') ? undefined : json['fullPath'],
        'farmName': !exists(json, 'farmName') ? undefined : json['farmName'],
        'hasNextPage': !exists(json, 'hasNextPage') ? undefined : json['hasNextPage'],
        'farmID': !exists(json, 'farmID') ? undefined : json['farmID'],
        'parentID': !exists(json, 'parentID') ? undefined : json['parentID'],
        'extension': !exists(json, 'extension') ? undefined : TreeNodeExtensionFromJSON(json['extension']),
        'parent': !exists(json, 'parent') ? undefined : TreeNodeFromJSON(json['parent']),
        'type': !exists(json, 'type') ? undefined : TreeNodeTypeFromJSON(json['type']),
        'spObjectID': !exists(json, 'spObjectID') ? undefined : json['spObjectID'],
        'networkId': !exists(json, 'networkId') ? undefined : json['networkId'],
        'parentSPObjectID': !exists(json, 'parentSPObjectID') ? undefined : json['parentSPObjectID'],
        'id': !exists(json, 'id') ? undefined : json['id'],
        'loadManagedPath': !exists(json, 'loadManagedPath') ? undefined : json['loadManagedPath'],
        'loadChildrenFromDB': !exists(json, 'loadChildrenFromDB') ? undefined : json['loadChildrenFromDB'],
        'loadedPageCount': !exists(json, 'loadedPageCount') ? undefined : json['loadedPageCount'],
        'children': !exists(json, 'children') ? undefined : (json['children'] === null ? null : (json['children'] as Array<any>).map(TreeNodeFromJSON)),
        'selectedChildren': !exists(json, 'selectedChildren') ? undefined : (json['selectedChildren'] === null ? null : (json['selectedChildren'] as Array<any>).map(TreeNodeFromJSON)),
        'filterUrls': !exists(json, 'filterUrls') ? undefined : json['filterUrls'],
        'filterType': !exists(json, 'filterType') ? undefined : json['filterType'],
        'checkNumber': !exists(json, 'checkNumber') ? undefined : json['checkNumber'],
        'selectedWebAppIdSubSiteProvServ': !exists(json, 'selectedWebAppId_SubSiteProvServ') ? undefined : json['selectedWebAppId_SubSiteProvServ'],
        'selectedSiteCollIdsSubSiteProvServ': !exists(json, 'selectedSiteCollIds_SubSiteProvServ') ? undefined : json['selectedSiteCollIds_SubSiteProvServ'],
        'childrenType': !exists(json, 'childrenType') ? undefined : json['childrenType'],
        'listId': !exists(json, 'listId') ? undefined : json['listId'],
        'serverRelativeUrl': !exists(json, 'serverRelativeUrl') ? undefined : json['serverRelativeUrl'],
        'userName': !exists(json, 'userName') ? undefined : json['userName'],
    };
}

export function TreeNodeToJSON(value?: TreeNode | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'webApplicationId': value.webApplicationId,
        'webApplicationUri': value.webApplicationUri,
        'siteCollectionId': value.siteCollectionId,
        'siteCollectionUrl': value.siteCollectionUrl,
        'siteId': value.siteId,
        'nodeId': value.nodeId,
        'startIndex': value.startIndex,
        'pageSize': value.pageSize,
        'pageIndex': value.pageIndex,
        'fullCount': value.fullCount,
        'name': value.name,
        'title': value.title,
        'description': value.description,
        'displayName': value.displayName,
        'managedPath': value.managedPath,
        'agentID': value.agentID,
        'fullPath': value.fullPath,
        'farmName': value.farmName,
        'hasNextPage': value.hasNextPage,
        'farmID': value.farmID,
        'parentID': value.parentID,
        'extension': TreeNodeExtensionToJSON(value.extension),
        'parent': TreeNodeToJSON(value.parent),
        'type': TreeNodeTypeToJSON(value.type),
        'spObjectID': value.spObjectID,
        'networkId': value.networkId,
        'parentSPObjectID': value.parentSPObjectID,
        'id': value.id,
        'loadManagedPath': value.loadManagedPath,
        'loadChildrenFromDB': value.loadChildrenFromDB,
        'loadedPageCount': value.loadedPageCount,
        'children': value.children === undefined ? undefined : (value.children === null ? null : (value.children as Array<any>).map(TreeNodeToJSON)),
        'selectedChildren': value.selectedChildren === undefined ? undefined : (value.selectedChildren === null ? null : (value.selectedChildren as Array<any>).map(TreeNodeToJSON)),
        'filterUrls': value.filterUrls,
        'filterType': value.filterType,
        'checkNumber': value.checkNumber,
        'selectedWebAppId_SubSiteProvServ': value.selectedWebAppIdSubSiteProvServ,
        'selectedSiteCollIds_SubSiteProvServ': value.selectedSiteCollIdsSubSiteProvServ,
        'childrenType': value.childrenType,
        'listId': value.listId,
        'serverRelativeUrl': value.serverRelativeUrl,
        'userName': value.userName,
    };
}


